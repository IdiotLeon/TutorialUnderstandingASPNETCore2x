#pragma checksum "C:\Project\ASPNETCore2x\Globoma\Globoma\Views\Conference\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80bf8d09c6149324e6ef709cc146a1c4e77c4d9c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Conference_Index), @"mvc.1.0.view", @"/Views/Conference/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Conference/Index.cshtml", typeof(AspNetCore.Views_Conference_Index))]
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
#line 1 "C:\Project\ASPNETCore2x\Globoma\Globoma\Views\Conference\Index.cshtml"
using Shared.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80bf8d09c6149324e6ef709cc146a1c4e77c4d9c", @"/Views/Conference/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22a826bca24665e72dd50a1ac892d710103e3136", @"/Views/_ViewImports.cshtml")]
    public class Views_Conference_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ConferenceModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(59, 363, true);
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-10 col-md-offset-2"">
        <table class=""table"">
            <tr>
                <th>
                    Name
                </th>
                <th>Location</th>
                <th>Start of event</th>
                <th>Attendees</th>
                <th>Actions</th>
            </tr>
            ");
            EndContext();
            BeginContext(423, 22, false);
#line 16 "C:\Project\ASPNETCore2x\Globoma\Globoma\Views\Conference\Index.cshtml"
       Write(Html.DisplayForModel());

#line default
#line hidden
            EndContext();
            BeginContext(445, 95, true);
            WriteLiteral("\r\n        </table>\r\n    </div>\r\n</div>\r\n<div class=\"row\">\r\n    <div class=\"col-md-2\">\r\n        ");
            EndContext();
            BeginContext(541, 78, false);
#line 22 "C:\Project\ASPNETCore2x\Globoma\Globoma\Views\Conference\Index.cshtml"
   Write(await Component.InvokeAsync("Statistics", new { statsCaption = "Statistics" }));

#line default
#line hidden
            EndContext();
            BeginContext(619, 116, true);
            WriteLiteral("\r\n        <vc:statistics stats-caption=\"Caption\"></vc:statistics>\r\n    </div>\r\n    <div class=\"col-md-10\">\r\n        ");
            EndContext();
            BeginContext(735, 27, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d336900e9c3344f1a2066deb268cf1fb", async() => {
                BeginContext(755, 3, true);
                WriteLiteral("Add");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(762, 22, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ConferenceModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
