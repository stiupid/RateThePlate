using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using RateThePlate.Models;

namespace RateThePlate.Controllers
{
    public class RatePlateController : Controller
    {
        
        private const string apiKey = "2cc15131ee6341b59d3394ca6d4729d3";
        //setting a pattern for the plate number
        private Regex Pattern = new Regex(@"(([A-Z]{2}.?)|(B.?[0-9]?))[0-9]{2}[ ]?[A-Z]{3}");
        private readonly lannisterContext _context;

        public RatePlateController(lannisterContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        //uploadig image
        [HttpPost]
        public async Task<IActionResult> UploadImage(IFormFile file)
        {
            if (file == null)
            {
                return View("Error", new ErrorViewModel { RequestId = "Rate Plate" });
            }
            //getting the image
            ViewData["originalImage"] = FileToImgSrcString(file);
            var result = String.Empty;
            //connecting to the api
            using (var httpClient = new HttpClient())
            {
                string baseUri = "https://ratetheplate.cognitiveservices.azure.com/vision/v1.0/ocr";
                httpClient.BaseAddress = new Uri(baseUri);
                httpClient.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", apiKey);
                HttpContent content = new StreamContent(file.OpenReadStream());
                content.Headers.ContentType = new MediaTypeWithQualityHeaderValue("application/octet-stream");
                var response = await httpClient.PostAsync(baseUri, content);
                string jsonResponse = await response.Content.ReadAsStringAsync();
                var jresult = JObject.Parse(jsonResponse);
                
                //getting the string from the jresult
                foreach (var region in jresult["regions"])
                {
                    foreach (var line in region["lines"])
                    {
                        foreach (var word in line["words"])
                        {
                            result = result + " " + word["text"].ToString();
                        }
                    }
                }
            }
            //verifying if the result contains a valid plate number
            var finalResult = Pattern.Match(result).Value;
            var numberNotFound = finalResult.Equals(String.Empty);

            if (numberNotFound)
            {
                ViewData["Error"] = "No number found, please enter another image!";
            }
            else
            {
                ViewData["PlateNumber"] = Regex.Replace(finalResult, "[^0-9A-Z]", "");
            }

            ViewData["Badges"] = new SelectList(_context.Badge, "Id", "Rating");
            return View("Index");
        }

        //adding feedback to the database
        [HttpPost]
        public async Task<IActionResult> SubmitFeedback(FeedbackViewModel input)
        {
            //getting existing carplate from the database.
            var myCarPlate = await _context.CarPlate
                .FirstOrDefaultAsync(m => m.PlateNumber == input.PlateNumber);
            //if the carplate number is not in the database
            if (myCarPlate == null)
            {
                var carPlate = new CarPlate { PlateNumber = input.PlateNumber };
                _context.Add(carPlate);
                _context.SaveChanges();

                myCarPlate = await _context.CarPlate
                .FirstOrDefaultAsync(m => m.PlateNumber == carPlate.PlateNumber);
            }
            //getting the badge from the database
            var myBadge = await _context.Badge
                .FirstOrDefaultAsync(m => m.Id == input.BadgeId);
           
            //creating a new feedback 
            var feedback = new Feedback
            {
                BadgeId = myBadge.Id,
                CarPlateId = myCarPlate.Id,
                Created = DateTime.Now
            };

            //saving feedback to db
            _context.Add(feedback);
            await _context.SaveChangesAsync();

            ViewBag.Success = $"Thank you! Your feedback for number {feedback.CarPlate.PlateNumber} was added with Success!";

            return View("Index");
        }
        //image upload code
        private string BytesToSrcString(byte[] bytes)
        {
            return "data:image/jpg;base64," + Convert.ToBase64String(bytes);
        }

        private string FileToImgSrcString(IFormFile file)
        {
            byte[] fileBytes;

            using (var stream = file.OpenReadStream())
            {
                using (var memoryStream = new MemoryStream())
                {
                    stream.CopyTo(memoryStream);
                    fileBytes = memoryStream.ToArray();
                }
            }

            return BytesToSrcString(fileBytes);
        }

    }

}