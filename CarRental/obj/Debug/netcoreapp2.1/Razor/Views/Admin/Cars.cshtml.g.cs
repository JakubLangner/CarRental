#pragma checksum "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Admin\Cars.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "324355a2fe1fddad9105c240e65afd2b89f92e0c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Cars), @"mvc.1.0.view", @"/Views/Admin/Cars.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Cars.cshtml", typeof(AspNetCore.Views_Admin_Cars))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"324355a2fe1fddad9105c240e65afd2b89f92e0c", @"/Views/Admin/Cars.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"529c8bd122fb22e8a9a1a9692f07307d414d2a18", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Cars : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Car>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateCar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DetailsCar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-bottom:3px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditCar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteCar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(25, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Admin\Cars.cshtml"
 if (TempData["SM"] != null)
{

#line default
#line hidden
            BeginContext(60, 47, true);
            WriteLiteral("    <div class=\"alert alert-success\">\r\n        ");
            EndContext();
            BeginContext(108, 14, false);
#line 6 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Admin\Cars.cshtml"
   Write(TempData["SM"]);

#line default
#line hidden
            EndContext();
            BeginContext(122, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 8 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Admin\Cars.cshtml"
}

#line default
#line hidden
#line 9 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Admin\Cars.cshtml"
 if (TempData["CarError"] != null)
{

#line default
#line hidden
            BeginContext(178, 46, true);
            WriteLiteral("    <div class=\"alert alert-danger\">\r\n        ");
            EndContext();
            BeginContext(225, 20, false);
#line 12 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Admin\Cars.cshtml"
   Write(TempData["CarError"]);

#line default
#line hidden
            EndContext();
            BeginContext(245, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 14 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Admin\Cars.cshtml"
}

#line default
#line hidden
#line 15 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Admin\Cars.cshtml"
 if (TempData["NoCars"] != null)
{

#line default
#line hidden
            BeginContext(299, 46, true);
            WriteLiteral("    <div class=\"alert alert-danger\">\r\n        ");
            EndContext();
            BeginContext(346, 18, false);
#line 18 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Admin\Cars.cshtml"
   Write(TempData["NoCars"]);

#line default
#line hidden
            EndContext();
            BeginContext(364, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 20 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Admin\Cars.cshtml"
}

#line default
#line hidden
            BeginContext(381, 434, true);
            WriteLiteral(@"
<table class=""table"" style=""background-color:azure"">
    <thead>
        <tr>
            <th>Numer Rejestracyjny</th>
            <th>Marka</th>
            <th>Model</th>
            <th>Silnik</th>
            <th>Rok Produkcji</th>
            <th>Przebieg</th>
            <th>Moc Silnika</th>
            <th>Opis</th>
            <th>Status</th>
            <th>Miniaturka</th>
            <th>
                ");
            EndContext();
            BeginContext(815, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "889b920d434f44adb712f25b66805499", async() => {
                BeginContext(871, 10, true);
                WriteLiteral("Dodaj nowy");
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
            BeginContext(885, 63, true);
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 41 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Admin\Cars.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(997, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(1036, 41, false);
#line 44 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Admin\Cars.cshtml"
               Write(Html.DisplayFor(modelItem => item.Plates));

#line default
#line hidden
            EndContext();
            BeginContext(1077, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1105, 39, false);
#line 45 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Admin\Cars.cshtml"
               Write(Html.DisplayFor(modelItem => item.Mark));

#line default
#line hidden
            EndContext();
            BeginContext(1144, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1172, 40, false);
#line 46 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Admin\Cars.cshtml"
               Write(Html.DisplayFor(modelItem => item.Model));

#line default
#line hidden
            EndContext();
            BeginContext(1212, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1240, 41, false);
#line 47 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Admin\Cars.cshtml"
               Write(Html.DisplayFor(modelItem => item.Engine));

#line default
#line hidden
            EndContext();
            BeginContext(1281, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1309, 51, false);
#line 48 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Admin\Cars.cshtml"
               Write(Html.DisplayFor(modelItem => item.YearOfProduction));

#line default
#line hidden
            EndContext();
            BeginContext(1360, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1388, 49, false);
#line 49 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Admin\Cars.cshtml"
               Write(Html.DisplayFor(modelItem => item.VehicleMileage));

#line default
#line hidden
            EndContext();
            BeginContext(1437, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1465, 46, false);
#line 50 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Admin\Cars.cshtml"
               Write(Html.DisplayFor(modelItem => item.EnginePower));

#line default
#line hidden
            EndContext();
            BeginContext(1511, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1539, 46, false);
#line 51 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Admin\Cars.cshtml"
               Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1585, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1613, 44, false);
#line 52 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Admin\Cars.cshtml"
               Write(Html.DisplayFor(modelItem => item.CarStatus));

#line default
#line hidden
            EndContext();
            BeginContext(1657, 31, true);
            WriteLiteral("</td>\r\n                <td><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1688, "\"", 1712, 1);
#line 53 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Admin\Cars.cshtml"
WriteAttributeValue("", 1694, item.ThumbnaulUrl, 1694, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1713, 77, true);
            WriteLiteral(" height=\"150\" width=\"150\" /></td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1790, 124, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fc222fe2088243f5bc0a24949011f801", async() => {
                BeginContext(1901, 9, true);
                WriteLiteral("Szczegóły");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 55 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Admin\Cars.cshtml"
                                                 WriteLiteral(item.CarId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1914, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(1936, 118, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cbb22f9901034cae8d2ea2bcafa76ce5", async() => {
                BeginContext(2044, 6, true);
                WriteLiteral("Edytuj");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 56 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Admin\Cars.cshtml"
                                              WriteLiteral(item.CarId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2054, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(2076, 118, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cb96618874e64a72ba02b10cf243ef77", async() => {
                BeginContext(2186, 4, true);
                WriteLiteral("Usuń");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 57 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Admin\Cars.cshtml"
                                                WriteLiteral(item.CarId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2194, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 60 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Admin\Cars.cshtml"
        }

#line default
#line hidden
            BeginContext(2249, 26, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Car>> Html { get; private set; }
    }
}
#pragma warning restore 1591