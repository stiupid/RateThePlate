#pragma checksum "X:\New folder\RateThePlate\RateThePlate\Views\Feedback\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d770546b84b8840a632b665494dfcda09e6b5329"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Feedback_Index), @"mvc.1.0.view", @"/Views/Feedback/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Feedback/Index.cshtml", typeof(AspNetCore.Views_Feedback_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "X:\New folder\RateThePlate\RateThePlate\Views\_ViewImports.cshtml"
using RateThePlate;

#line default
#line hidden
#line 2 "X:\New folder\RateThePlate\RateThePlate\Views\_ViewImports.cshtml"
using RateThePlate.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d770546b84b8840a632b665494dfcda09e6b5329", @"/Views/Feedback/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c522ab3c6a0b2aff60f25c98d5be1d98dddb94f", @"/Views/_ViewImports.cshtml")]
    public class Views_Feedback_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RateThePlate.Models.BadgeCountViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Feedback", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("picture"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/icons/monkey.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/icons/bear.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/icons/bee.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/icons/cat.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/icons/dog.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/icons/dragon.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/icons/monster.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/icons/owl.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/icons/turtle.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/icons/flamingo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(61, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "X:\New folder\RateThePlate\RateThePlate\Views\Feedback\Index.cshtml"
  
    ViewData["Title"] = "Index";
    int counter = 0;
    //showing or not showing badge count before search in index
    if (Model != null)
    {
        foreach (var item in Model)
        {
            counter = item.Count;
        }
    }

#line default
#line hidden
            BeginContext(323, 122, true);
            WriteLiteral("<link rel=\"stylesheet\" type=\"text/css\" href=\"/CSS/site.css\">\r\n\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-12\">\r\n        ");
            EndContext();
            BeginContext(445, 695, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b831556eac5a448091263752ac5ee81f", async() => {
                BeginContext(497, 558, true);
                WriteLiteral(@"
            <div class=""form-horizontal"">
                <div class=""form-group"">
                    <label>Car plate number:</label>
                    <input class=""form-control"" type=""text"" placeholder=""CJ01AAA"" onfocus=""this.placeholder=''"" onblur=""this.placeholder='CJ01AAA'"" name=""SearchString"" style=""width:auto; max-width:500px"" required>
                </div>
                <div class=""form-group"">
                    <input type=""submit"" value=""Search"" class=""btn-primary btn""/>
                    <h5 id=""error"" style=""color:red"">");
                EndContext();
                BeginContext(1056, 17, false);
#line 28 "X:\New folder\RateThePlate\RateThePlate\Views\Feedback\Index.cshtml"
                                                Write(ViewData["Error"]);

#line default
#line hidden
                EndContext();
                BeginContext(1073, 60, true);
                WriteLiteral(" </h5>\r\n                </div>\r\n            </div>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1140, 123, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div class=\"row\">\r\n    <div class=\"form-group\">\r\n        <table class=\"table\">\r\n            <thead>\r\n");
            EndContext();
#line 38 "X:\New folder\RateThePlate\RateThePlate\Views\Feedback\Index.cshtml"
                 if (string.IsNullOrEmpty(Convert.ToString(ViewData["Error"])))
                {

#line default
#line hidden
            BeginContext(1363, 109, true);
            WriteLiteral("                <tr>\r\n                    <th>\r\n                        CarPlate\r\n                    </th>\r\n");
            EndContext();
#line 44 "X:\New folder\RateThePlate\RateThePlate\Views\Feedback\Index.cshtml"
                     if (counter != 0)
                    {

#line default
#line hidden
            BeginContext(1535, 96, true);
            WriteLiteral("                        <th>\r\n                            Badge\r\n                        </th>\r\n");
            EndContext();
            BeginContext(1633, 202, true);
            WriteLiteral("                        <th>\r\n                            Badge Count\r\n                        </th>\r\n                        <th>\r\n                            Reactions\r\n                        </th>\r\n");
            EndContext();
#line 56 "X:\New folder\RateThePlate\RateThePlate\Views\Feedback\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1858, 113, true);
            WriteLiteral("\r\n                    <th>\r\n                        Created\r\n                    </th>\r\n\r\n                </tr>\r\n");
            EndContext();
#line 63 "X:\New folder\RateThePlate\RateThePlate\Views\Feedback\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1990, 43, true);
            WriteLiteral("            </thead>\r\n            <tbody>\r\n");
            EndContext();
#line 66 "X:\New folder\RateThePlate\RateThePlate\Views\Feedback\Index.cshtml"
                 if (Model != null)
                {
                    foreach (var item in Model)
                    {

#line default
#line hidden
            BeginContext(2161, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(2234, 64, false);
#line 72 "X:\New folder\RateThePlate\RateThePlate\Views\Feedback\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Feedback.CarPlate.PlateNumber));

#line default
#line hidden
            EndContext();
            BeginContext(2298, 29, true);
            WriteLiteral("\r\n                    </td>\r\n");
            EndContext();
#line 74 "X:\New folder\RateThePlate\RateThePlate\Views\Feedback\Index.cshtml"
                     if (item.Count != 0)
                    {

#line default
#line hidden
            BeginContext(2393, 58, true);
            WriteLiteral("                        <td>\r\n                            ");
            EndContext();
            BeginContext(2452, 56, false);
#line 77 "X:\New folder\RateThePlate\RateThePlate\Views\Feedback\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Feedback.Badge.Rating));

#line default
#line hidden
            EndContext();
            BeginContext(2508, 33, true);
            WriteLiteral("\r\n                        </td>\r\n");
            EndContext();
            BeginContext(2543, 58, true);
            WriteLiteral("                        <td>\r\n                            ");
            EndContext();
            BeginContext(2602, 40, false);
#line 81 "X:\New folder\RateThePlate\RateThePlate\Views\Feedback\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Count));

#line default
#line hidden
            EndContext();
            BeginContext(2642, 33, true);
            WriteLiteral("\r\n                        </td>\r\n");
            EndContext();
            BeginContext(2736, 41, true);
            WriteLiteral("                    <td align=\"center\">\r\n");
            EndContext();
#line 86 "X:\New folder\RateThePlate\RateThePlate\Views\Feedback\Index.cshtml"
                         switch (item.Feedback.BadgeId)
                        {
                            case 1:

#line default
#line hidden
            BeginContext(2898, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(2930, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "da041955038847f9848786f873938721", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2982, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 90 "X:\New folder\RateThePlate\RateThePlate\Views\Feedback\Index.cshtml"
                                break;
                            case 2:

#line default
#line hidden
            BeginContext(3061, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(3093, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b6bd85c0fe4d4123b0bbdd69f3203d03", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3143, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 93 "X:\New folder\RateThePlate\RateThePlate\Views\Feedback\Index.cshtml"
                                break;
                            case 3:

#line default
#line hidden
            BeginContext(3222, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(3254, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3c240ab039aa4cef9885b9bce4de9d67", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3303, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 96 "X:\New folder\RateThePlate\RateThePlate\Views\Feedback\Index.cshtml"
                                break;
                            case 4:

#line default
#line hidden
            BeginContext(3382, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(3414, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "14b8562ee6d945d8b834f78aab9cb017", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3463, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 99 "X:\New folder\RateThePlate\RateThePlate\Views\Feedback\Index.cshtml"
                                break;
                            case 5:

#line default
#line hidden
            BeginContext(3542, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(3574, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c05b797f22db4c5391a0aa9ca09eea71", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3623, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 102 "X:\New folder\RateThePlate\RateThePlate\Views\Feedback\Index.cshtml"
                                break;
                            case 6:

#line default
#line hidden
            BeginContext(3702, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(3734, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "219966a0c6074956b29493efb1293875", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3786, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 105 "X:\New folder\RateThePlate\RateThePlate\Views\Feedback\Index.cshtml"
                                break;
                            case 7:

#line default
#line hidden
            BeginContext(3865, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(3897, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b6a4d4603d9c4a839c783b6268673aa7", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3950, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 108 "X:\New folder\RateThePlate\RateThePlate\Views\Feedback\Index.cshtml"
                                break;
                            case 8:

#line default
#line hidden
            BeginContext(4029, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(4061, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1a2edb5086fe4ffcb69d869777424904", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4110, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 111 "X:\New folder\RateThePlate\RateThePlate\Views\Feedback\Index.cshtml"
                                break;
                            case 9:

#line default
#line hidden
            BeginContext(4189, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(4221, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d9817a72cffb4d85bc13161f520ff257", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4273, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 114 "X:\New folder\RateThePlate\RateThePlate\Views\Feedback\Index.cshtml"
                                break;

                            default:

#line default
#line hidden
            BeginContext(4353, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(4354, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "91c2d9b140a84128bda8f37dfd8d0854", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4408, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 117 "X:\New folder\RateThePlate\RateThePlate\Views\Feedback\Index.cshtml"
                                break;
                        }

#line default
#line hidden
            BeginContext(4477, 27, true);
            WriteLiteral("                    </td>\r\n");
            EndContext();
#line 120 "X:\New folder\RateThePlate\RateThePlate\Views\Feedback\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(4527, 50, true);
            WriteLiteral("                    <td>\r\n                        ");
            EndContext();
            BeginContext(4578, 51, false);
#line 122 "X:\New folder\RateThePlate\RateThePlate\Views\Feedback\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Feedback.Created));

#line default
#line hidden
            EndContext();
            BeginContext(4629, 54, true);
            WriteLiteral("\r\n                    </td>\r\n\r\n                </tr>\r\n");
            EndContext();
#line 126 "X:\New folder\RateThePlate\RateThePlate\Views\Feedback\Index.cshtml"
                    }
                }

#line default
#line hidden
            BeginContext(4725, 58, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RateThePlate.Models.BadgeCountViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
