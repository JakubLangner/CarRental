#pragma checksum "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\User\MyOrders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d561d7bd3db166c1aadf81e77a3c91897cf1f022"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_MyOrders), @"mvc.1.0.view", @"/Views/User/MyOrders.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/MyOrders.cshtml", typeof(AspNetCore.Views_User_MyOrders))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d561d7bd3db166c1aadf81e77a3c91897cf1f022", @"/Views/User/MyOrders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"529c8bd122fb22e8a9a1a9692f07307d414d2a18", @"/Views/_ViewImports.cshtml")]
    public class Views_User_MyOrders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CarRental.Models.Rent>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 394, true);
            WriteLiteral(@"
<table class=""table"" style=""background-color:azure"">
    <thead>
        <tr>
            <th>Numer Samochodu</th>
            <th>Opis</th>
            <th>Faktura</th>
            <th>Notatka</th>
            <th>Cena</th>
            <th>Adres</th>
            <th>Początek</th>
            <th>Koniec</th>
            <th>Status</th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 18 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\User\MyOrders.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(486, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(517, 40, false);
#line 21 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\User\MyOrders.cshtml"
           Write(Html.DisplayFor(modelItem => item.CarId));

#line default
#line hidden
            EndContext();
            BeginContext(557, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(581, 46, false);
#line 22 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\User\MyOrders.cshtml"
           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(627, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(651, 44, false);
#line 23 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\User\MyOrders.cshtml"
           Write(Html.DisplayFor(modelItem => item.IsInvoice));

#line default
#line hidden
            EndContext();
            BeginContext(695, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(719, 39, false);
#line 24 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\User\MyOrders.cshtml"
           Write(Html.DisplayFor(modelItem => item.Note));

#line default
#line hidden
            EndContext();
            BeginContext(758, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(782, 40, false);
#line 25 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\User\MyOrders.cshtml"
           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(822, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(846, 46, false);
#line 26 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\User\MyOrders.cshtml"
           Write(Html.DisplayFor(modelItem => item.RentAddress));

#line default
#line hidden
            EndContext();
            BeginContext(892, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(916, 44, false);
#line 27 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\User\MyOrders.cshtml"
           Write(Html.DisplayFor(modelItem => item.RentStart));

#line default
#line hidden
            EndContext();
            BeginContext(960, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(984, 42, false);
#line 28 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\User\MyOrders.cshtml"
           Write(Html.DisplayFor(modelItem => item.RentEnd));

#line default
#line hidden
            EndContext();
            BeginContext(1026, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1050, 45, false);
#line 29 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\User\MyOrders.cshtml"
           Write(Html.DisplayFor(modelItem => item.RentStatus));

#line default
#line hidden
            EndContext();
            BeginContext(1095, 30, true);
            WriteLiteral("</td>\r\n\r\n\r\n\r\n\r\n        </tr>\r\n");
            EndContext();
#line 35 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\User\MyOrders.cshtml"
        }

#line default
#line hidden
            BeginContext(1136, 26, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CarRental.Models.Rent>> Html { get; private set; }
    }
}
#pragma warning restore 1591