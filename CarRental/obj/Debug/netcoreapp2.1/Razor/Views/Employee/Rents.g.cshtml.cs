#pragma checksum "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Employee\Rents.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f659cf29c07b1f0b989f61aef07a96b9490017b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Rents), @"mvc.1.0.view", @"/Views/Employee/Rents.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employee/Rents.cshtml", typeof(AspNetCore.Views_Employee_Rents))]
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
#line 1 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\_ViewImports.cshtml"
using CarRental;

#line default
#line hidden
#line 2 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\_ViewImports.cshtml"
using CarRental.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f659cf29c07b1f0b989f61aef07a96b9490017b5", @"/Views/Employee/Rents.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"529c8bd122fb22e8a9a1a9692f07307d414d2a18", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Rents : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Rent>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Execute", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-bottom:3px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToArchives", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(26, 509, true);
            WriteLiteral(@"
<table class=""table"" style=""background-color:azure"">
    <thead>
        <tr>
            <th>Numer Wypożyczenia</th>
            <th>Numer samochodu</th>
            <th>Początek wypożyczenia</th>
            <th>Koniec wypożyczenia</th>
            <th>Adres</th>
            <th>Faktura</th>
            <th>Notatka</th>
            <th>Opis</th>
            <th>Numer klienta</th>
            <th>Dodatkowy Sprzęt</th>
            <th>Status</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 20 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Employee\Rents.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(584, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(615, 41, false);
#line 23 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Employee\Rents.cshtml"
           Write(Html.DisplayFor(modelItem => item.RentId));

#line default
#line hidden
            EndContext();
            BeginContext(656, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(680, 40, false);
#line 24 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Employee\Rents.cshtml"
           Write(Html.DisplayFor(modelItem => item.CarId));

#line default
#line hidden
            EndContext();
            BeginContext(720, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(744, 44, false);
#line 25 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Employee\Rents.cshtml"
           Write(Html.DisplayFor(modelItem => item.RentStart));

#line default
#line hidden
            EndContext();
            BeginContext(788, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(812, 42, false);
#line 26 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Employee\Rents.cshtml"
           Write(Html.DisplayFor(modelItem => item.RentEnd));

#line default
#line hidden
            EndContext();
            BeginContext(854, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(878, 46, false);
#line 27 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Employee\Rents.cshtml"
           Write(Html.DisplayFor(modelItem => item.RentAddress));

#line default
#line hidden
            EndContext();
            BeginContext(924, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(948, 44, false);
#line 28 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Employee\Rents.cshtml"
           Write(Html.DisplayFor(modelItem => item.IsInvoice));

#line default
#line hidden
            EndContext();
            BeginContext(992, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1016, 39, false);
#line 29 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Employee\Rents.cshtml"
           Write(Html.DisplayFor(modelItem => item.Note));

#line default
#line hidden
            EndContext();
            BeginContext(1055, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1079, 46, false);
#line 30 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Employee\Rents.cshtml"
           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1125, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1149, 41, false);
#line 31 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Employee\Rents.cshtml"
           Write(Html.DisplayFor(modelItem => item.UserId));

#line default
#line hidden
            EndContext();
            BeginContext(1190, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1214, 56, false);
#line 32 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Employee\Rents.cshtml"
           Write(Html.DisplayFor(modelItem => item.AdditionalEquipmentId));

#line default
#line hidden
            EndContext();
            BeginContext(1270, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1294, 45, false);
#line 33 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Employee\Rents.cshtml"
           Write(Html.DisplayFor(modelItem => item.RentStatus));

#line default
#line hidden
            EndContext();
            BeginContext(1339, 41, true);
            WriteLiteral("</td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1380, 121, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39ea92887a9f45a18ba513b9b9a5af5d", async() => {
                BeginContext(1489, 8, true);
                WriteLiteral("Realizuj");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 35 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Employee\Rents.cshtml"
                                          WriteLiteral(item.RentId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1501, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1519, 136, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f270fadea5a4db0bc5cb00d984466f6", async() => {
                BeginContext(1634, 17, true);
                WriteLiteral("Dodaj do archiwum");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 36 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Employee\Rents.cshtml"
                                                WriteLiteral(item.RentId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1655, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 39 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Employee\Rents.cshtml"
        }

#line default
#line hidden
            BeginContext(1702, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Rent>> Html { get; private set; }
    }
}
#pragma warning restore 1591
