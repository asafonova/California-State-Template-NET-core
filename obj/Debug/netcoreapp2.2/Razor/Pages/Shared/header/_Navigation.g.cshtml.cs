#pragma checksum "C:\Users\konstantin.koryaka\Documents\projects\California-State-Template-NET-Core\California-State-Template-NET-core\Pages\Shared\header\_Navigation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46d00ce9954d75ff4bdce4ce4fcdb9f8b34188e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebTemplateNETCore.Pages.Shared.header.Pages_Shared_header__Navigation), @"mvc.1.0.view", @"/Pages/Shared/header/_Navigation.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Pages/Shared/header/_Navigation.cshtml", typeof(WebTemplateNETCore.Pages.Shared.header.Pages_Shared_header__Navigation))]
namespace WebTemplateNETCore.Pages.Shared.header
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\konstantin.koryaka\Documents\projects\California-State-Template-NET-Core\California-State-Template-NET-core\Pages\_ViewImports.cshtml"
using WebTemplateNETCore;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46d00ce9954d75ff4bdce4ce4fcdb9f8b34188e1", @"/Pages/Shared/header/_Navigation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2565b3d7548125887da159a3d3fdf11883a93a5", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared_header__Navigation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/About", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("first-level-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Structure", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Contact", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("Search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("pos-rel"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/serp.html"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 416, true);
            WriteLiteral(@"<!--  Navigation -->
<div class=""navigation-search"">
    <!-- Include Navigation -->
    <nav id=""navigation"" class=""main-navigation singlelevelnav"">
        <ul id=""nav_list"" class=""top-level-nav"">
            <li class=""home-link nav-item"">
                <a href=""/"" class=""first-level-link""><span id=""nav_home_container"" class=""ca-gov-icon-home"" aria-hidden=""true""></span>Home</a>
            </li>


");
            EndContext();
#line 11 "C:\Users\konstantin.koryaka\Documents\projects\California-State-Template-NET-Core\California-State-Template-NET-core\Pages\Shared\header\_Navigation.cshtml"
               var rv = ViewContext.RouteData.Values;
            string page = $"{rv["page"]}".ToLowerInvariant(); 

#line default
#line hidden
            BeginContext(536, 23, true);
            WriteLiteral("\r\n\r\n                <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 559, "\"", 612, 2);
            WriteAttributeValue("", 567, "nav-item", 567, 8, true);
#line 15 "C:\Users\konstantin.koryaka\Documents\projects\California-State-Template-NET-Core\California-State-Template-NET-core\Pages\Shared\header\_Navigation.cshtml"
WriteAttributeValue(" ", 575, page == "/about" ?  "active" : "", 576, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(613, 23, true);
            WriteLiteral(">\r\n                    ");
            EndContext();
            BeginContext(636, 119, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46d00ce9954d75ff4bdce4ce4fcdb9f8b34188e17391", async() => {
                BeginContext(682, 69, true);
                WriteLiteral("<span class=\"ca-gov-icon-info-bubble\" aria-hidden=\"true\"></span>About");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(755, 46, true);
            WriteLiteral("\r\n                </li>\r\n\r\n                <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 801, "\"", 858, 2);
            WriteAttributeValue("", 809, "nav-item", 809, 8, true);
#line 19 "C:\Users\konstantin.koryaka\Documents\projects\California-State-Template-NET-Core\California-State-Template-NET-core\Pages\Shared\header\_Navigation.cshtml"
WriteAttributeValue(" ", 817, page == "/structure" ?  "active" : "", 818, 40, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(859, 23, true);
            WriteLiteral(">\r\n                    ");
            EndContext();
            BeginContext(882, 125, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46d00ce9954d75ff4bdce4ce4fcdb9f8b34188e19548", async() => {
                BeginContext(932, 71, true);
                WriteLiteral("<span class=\"ca-gov-icon-flowchart\" aria-hidden=\"true\"></span>Structure");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1007, 548, true);
            WriteLiteral(@"
                </li>

                <li class=""nav-item"">
                    <a href = ""https://github.com/Office-of-Digital-Innovation"" target=""_blank"" class=""first-level-link""><span class=""ca-gov-icon-download"" aria-hidden=""true""></span>Download</a>
                </li>

                <li class=""nav-item"">
                    <a href = ""https://webstandards.ca.gov"" target=""_blank"" class=""first-level-link""><span class=""ca-gov-icon-state"" aria-hidden=""true""></span>Web Standards</a>
                </li>

                <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1555, "\"", 1610, 2);
            WriteAttributeValue("", 1563, "nav-item", 1563, 8, true);
#line 31 "C:\Users\konstantin.koryaka\Documents\projects\California-State-Template-NET-Core\California-State-Template-NET-core\Pages\Shared\header\_Navigation.cshtml"
WriteAttributeValue(" ", 1571, page == "/contact" ?  "active" : "", 1572, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1611, 23, true);
            WriteLiteral(">\r\n                    ");
            EndContext();
            BeginContext(1634, 125, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46d00ce9954d75ff4bdce4ce4fcdb9f8b34188e112236", async() => {
                BeginContext(1682, 73, true);
                WriteLiteral("<span class=\"ca-gov-icon-contact-us\" aria-hidden=\"true\"></span>Contact Us");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1759, 1180, true);
            WriteLiteral(@"
                </li>

                <li class=""nav-item"" id=""nav-item-search"">
                    <a href = ""javascript:;"" class=""first-level-link""  aria-label=""Search Button""><span class=""ca-gov-icon-search"" aria-hidden=""true""></span>Search</a>
                </li>

            </ul>
        </nav>
        <div id = ""head-search"" class=""search-container"">
            <script type = ""text/javascript"" >
                        var cx = '001779225245372747843:9s-idxui5pk';// Step 7: Update this value with your search engine unique ID. Submit a request to the CDT Service Desk if you don't already know your unique search engine ID.
                        var gcse = document.createElement('script');
                gcse.type = 'text/javascript';
                        gcse.async = true;
                        gcse.src = 'https://cse.google.com/cse.js?cx=' + cx;
                        var s = document.getElementsByTagName('script');
                s[s.length - 1].parentNode.insertBefore(");
            WriteLiteral("gcse, s[s.length - 1]);\r\n                \r\n\r\n        </script>\r\n        <!-- Google Custom Search -->\r\n            <div class=\"container\">\r\n                ");
            EndContext();
            BeginContext(2939, 901, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46d00ce9954d75ff4bdce4ce4fcdb9f8b34188e115008", async() => {
                BeginContext(2993, 840, true);
                WriteLiteral(@"
                    <span class=""sr-only"" id=""SearchInput"">Custom Google Search</span>
                    <input type=""text"" id=""q"" name=""q"" aria-labelledby=""SearchInput"" placeholder=""Search this website"" class=""search-textfield height-50 border-0 p-x-sm w-100"" />
                    <button type=""submit"" class=""pos-abs gsc-search-button top-0 width-50 height-50 border-0 bg-transparent""><span class=""ca-gov-icon-search font-size-30 color-gray"" aria-hidden=""true""></span><span class=""sr-only"">Submit</span></button>
                    <div class=""width-50 height-50 close-search-btn""><button class=""close-search gsc-clear-button width-50 height-50 border-0 bg-transparent pos-rel"" type=""reset""><span class=""sr-only"">Close Search</span><span class=""ca-gov-icon-close-mark"" aria-hidden=""true""></span></button></div>
                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3840, 44, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
