#pragma checksum "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Employee\ArchivesDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "207581ce6620170a4e041709f14e8786de88ee56"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_ArchivesDetails), @"mvc.1.0.view", @"/Views/Employee/ArchivesDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employee/ArchivesDetails.cshtml", typeof(AspNetCore.Views_Employee_ArchivesDetails))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"207581ce6620170a4e041709f14e8786de88ee56", @"/Views/Employee/ArchivesDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"529c8bd122fb22e8a9a1a9692f07307d414d2a18", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_ArchivesDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CarRental.ViewModels.Archives.ArchivesVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Archives", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(49, 141, true);
            WriteLiteral("\r\n<div>\r\n    <div class=\"thumbnail\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-3\">\r\n                <h3>Numer wypożyczenia: ");
            EndContext();
            BeginContext(191, 12, false);
#line 7 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Employee\ArchivesDetails.cshtml"
                                   Write(Model.RentId);

#line default
#line hidden
            EndContext();
            BeginContext(203, 44, true);
            WriteLiteral("</h3>\r\n                <h4>Numer samochodu: ");
            EndContext();
            BeginContext(248, 11, false);
#line 8 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Employee\ArchivesDetails.cshtml"
                                Write(Model.CarId);

#line default
#line hidden
            EndContext();
            BeginContext(259, 34, true);
            WriteLiteral("</h4>\r\n                <h4>Adres: ");
            EndContext();
            BeginContext(294, 17, false);
#line 9 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Employee\ArchivesDetails.cshtml"
                      Write(Model.RentAddress);

#line default
#line hidden
            EndContext();
            BeginContext(311, 55, true);
            WriteLiteral("</h4>\r\n                <h4>Numer sprzedtu dodatkowego: ");
            EndContext();
            BeginContext(367, 27, false);
#line 10 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Employee\ArchivesDetails.cshtml"
                                           Write(Model.AdditionalEquipmentId);

#line default
#line hidden
            EndContext();
            BeginContext(394, 33, true);
            WriteLiteral("</h4>\r\n                <h4>Cena: ");
            EndContext();
            BeginContext(428, 11, false);
#line 11 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Employee\ArchivesDetails.cshtml"
                     Write(Model.Price);

#line default
#line hidden
            EndContext();
            BeginContext(439, 45, true);
            WriteLiteral("</h4>\r\n                <h4>Czy była faktura: ");
            EndContext();
            BeginContext(485, 15, false);
#line 12 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Employee\ArchivesDetails.cshtml"
                                 Write(Model.IsInvoice);

#line default
#line hidden
            EndContext();
            BeginContext(500, 36, true);
            WriteLiteral("</h4>\r\n                <h4>Notatka: ");
            EndContext();
            BeginContext(537, 10, false);
#line 13 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Employee\ArchivesDetails.cshtml"
                        Write(Model.Note);

#line default
#line hidden
            EndContext();
            BeginContext(547, 35, true);
            WriteLiteral("</h4>\r\n                <h4>Status: ");
            EndContext();
            BeginContext(583, 16, false);
#line 14 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Employee\ArchivesDetails.cshtml"
                       Write(Model.RentStatus);

#line default
#line hidden
            EndContext();
            BeginContext(599, 46, true);
            WriteLiteral("</h4>\r\n                <h4>Numer użytkownika: ");
            EndContext();
            BeginContext(646, 12, false);
#line 15 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Employee\ArchivesDetails.cshtml"
                                  Write(Model.UserId);

#line default
#line hidden
            EndContext();
            BeginContext(658, 50, true);
            WriteLiteral("</h4>\r\n                <h4>Początek wypożyczenia: ");
            EndContext();
            BeginContext(709, 15, false);
#line 16 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Employee\ArchivesDetails.cshtml"
                                      Write(Model.RentStart);

#line default
#line hidden
            EndContext();
            BeginContext(724, 48, true);
            WriteLiteral("</h4>\r\n                <h4>Koniec wypożyczenia: ");
            EndContext();
            BeginContext(773, 13, false);
#line 17 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Employee\ArchivesDetails.cshtml"
                                    Write(Model.RentEnd);

#line default
#line hidden
            EndContext();
            BeginContext(786, 32, true);
            WriteLiteral("</h4>\r\n                <p>Opis: ");
            EndContext();
            BeginContext(819, 17, false);
#line 18 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Employee\ArchivesDetails.cshtml"
                    Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(836, 150, true);
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\"col-md-3\" style=\"padding-right:50px\">\r\n                <h3 class=\"pull-right\">\r\n                    ");
            EndContext();
            BeginContext(986, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ed776a2f5234dc5aee34892b8dc84b8", async() => {
                BeginContext(1035, 6, true);
                WriteLiteral("Powrót");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
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
            BeginContext(1045, 79, true);
            WriteLiteral("\r\n                </h3>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CarRental.ViewModels.Archives.ArchivesVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
