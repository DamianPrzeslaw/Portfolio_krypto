#pragma checksum "C:\Users\Damian\Desktop\C++\C#\Portfolio_Krypto\Portfolio_Krypto\Views\Tokens\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db179de530213b9bb23b416f7a9b55d3532c01e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tokens_Index), @"mvc.1.0.view", @"/Views/Tokens/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Damian\Desktop\C++\C#\Portfolio_Krypto\Portfolio_Krypto\Views\_ViewImports.cshtml"
using Portfolio_Krypto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Damian\Desktop\C++\C#\Portfolio_Krypto\Portfolio_Krypto\Views\_ViewImports.cshtml"
using Portfolio_Krypto.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db179de530213b9bb23b416f7a9b55d3532c01e9", @"/Views/Tokens/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"425c30090cac0061dcfb2c828e018b75a1e61979", @"/Views/_ViewImports.cshtml")]
    public class Views_Tokens_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Portfolio_Krypto.Models.TokenExpanded>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-light"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Damian\Desktop\C++\C#\Portfolio_Krypto\Portfolio_Krypto\Views\Tokens\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<style>\r\n    td {color: white}\r\n    h1{color:white}\r\n    th {  color: White   }\r\n    a {color: whitesmoke  }\r\n</style>\r\n\r\n<h1>Twoje Tokeny</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db179de530213b9bb23b416f7a9b55d3532c01e94895", async() => {
                WriteLiteral("Dodaj");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</p>
<table class=""table"" >
    <thead>
        <tr>
            <th>
                Token
            </th>
            <th>
                Wartosc
            </th>
            <th>
                Posiadane tokeny
            </th>
            <th>
                Obecna cena
            </th>
            <th>
                Profit
            </th>
          
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 41 "C:\Users\Damian\Desktop\C++\C#\Portfolio_Krypto\Portfolio_Krypto\Views\Tokens\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n\r\n            <td>\r\n                <img");
            BeginWriteAttribute("src", " src=", 844, "", 888, 1);
#nullable restore
#line 45 "C:\Users\Damian\Desktop\C++\C#\Portfolio_Krypto\Portfolio_Krypto\Views\Tokens\Index.cshtml"
WriteAttributeValue("", 849, Html.DisplayFor(ModelItem=>item.image), 849, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"30\" ,height=\"30\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db179de530213b9bb23b416f7a9b55d3532c01e97299", async() => {
                WriteLiteral(" ");
#nullable restore
#line 46 "C:\Users\Damian\Desktop\C++\C#\Portfolio_Krypto\Portfolio_Krypto\Views\Tokens\Index.cshtml"
                                                                                        Write(Html.DisplayFor(modelItem => item.tokenName));

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-name", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 46 "C:\Users\Damian\Desktop\C++\C#\Portfolio_Krypto\Portfolio_Krypto\Views\Tokens\Index.cshtml"
                                                               WriteLiteral(item.tokenName);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["name"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-name", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["name"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\Users\Damian\Desktop\C++\C#\Portfolio_Krypto\Portfolio_Krypto\Views\Tokens\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.worth_current));

#line default
#line hidden
#nullable disable
            WriteLiteral("$\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "C:\Users\Damian\Desktop\C++\C#\Portfolio_Krypto\Portfolio_Krypto\Views\Tokens\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 55 "C:\Users\Damian\Desktop\C++\C#\Portfolio_Krypto\Portfolio_Krypto\Views\Tokens\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.current_price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
#nullable restore
#line 58 "C:\Users\Damian\Desktop\C++\C#\Portfolio_Krypto\Portfolio_Krypto\Views\Tokens\Index.cshtml"
                 if (item.profit > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span style=\"color:green\">");
#nullable restore
#line 60 "C:\Users\Damian\Desktop\C++\C#\Portfolio_Krypto\Portfolio_Krypto\Views\Tokens\Index.cshtml"
                                         Write(Html.DisplayFor(modelItem => item.profit));

#line default
#line hidden
#nullable disable
            WriteLiteral("%</span>\r\n");
#nullable restore
#line 61 "C:\Users\Damian\Desktop\C++\C#\Portfolio_Krypto\Portfolio_Krypto\Views\Tokens\Index.cshtml"

                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span style=\"color:red\">");
#nullable restore
#line 65 "C:\Users\Damian\Desktop\C++\C#\Portfolio_Krypto\Portfolio_Krypto\Views\Tokens\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.profit));

#line default
#line hidden
#nullable disable
            WriteLiteral("% </span>\r\n");
#nullable restore
#line 66 "C:\Users\Damian\Desktop\C++\C#\Portfolio_Krypto\Portfolio_Krypto\Views\Tokens\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n        </tr>\r\n");
#nullable restore
#line 69 "C:\Users\Damian\Desktop\C++\C#\Portfolio_Krypto\Portfolio_Krypto\Views\Tokens\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Portfolio_Krypto.Models.TokenExpanded>> Html { get; private set; }
    }
}
#pragma warning restore 1591
