#pragma checksum "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Admin\Users.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64bf5f4dd84d0656383081b36f1509ba4fd57c2b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Users), @"mvc.1.0.view", @"/Views/Admin/Users.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/Users.cshtml", typeof(AspNetCore.Views_Admin_Users))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64bf5f4dd84d0656383081b36f1509ba4fd57c2b", @"/Views/Admin/Users.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"529c8bd122fb22e8a9a1a9692f07307d414d2a18", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Users : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CarRental.ViewModels.Admin.AdminUsersView>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("editLine"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("deleteLine"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Admin\Users.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(88, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Admin\Users.cshtml"
  
    ViewData["Title"] = "User";

#line default
#line hidden
            BeginContext(130, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(197, 409, true);
            WriteLiteral(@"<div id=""modal-placeholder""></div>

<h2 style=""text-align: center;"">Wszyscy użytkownicy zarejestrowani w systemie</h2>

<h2>Użytkownicy</h2>
<table class=""table"" style=""background-color:azure"">

    <thead>
        <tr>
            <th>Użytkownik</th>
            <th>Email</th>
            <th>Telefon</th>
            <th>Imię</th>
            <th>Nazwisko</th>
        </tr>
    </thead>

");
            EndContext();
#line 29 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Admin\Users.cshtml"
     foreach (var user in Model.ToList())
    {
        if (user.Role.ToArray().Contains("User"))
        {

#line default
#line hidden
            BeginContext(718, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(757, 13, false);
#line 34 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Admin\Users.cshtml"
               Write(user.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(770, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(798, 10, false);
#line 35 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Admin\Users.cshtml"
               Write(user.Email);

#line default
#line hidden
            EndContext();
            BeginContext(808, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(836, 16, false);
#line 36 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Admin\Users.cshtml"
               Write(user.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(852, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(880, 14, false);
#line 37 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Admin\Users.cshtml"
               Write(user.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(894, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(922, 13, false);
#line 38 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Admin\Users.cshtml"
               Write(user.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(935, 31, true);
            WriteLiteral("</td>\r\n                <!--<td>");
            EndContext();
            BeginContext(967, 37, false);
#line 39 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Admin\Users.cshtml"
                   Write(string.Join(",", user.Role.ToArray()));

#line default
#line hidden
            EndContext();
            BeginContext(1004, 52, true);
            WriteLiteral("</td>-->\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1056, 116, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd227c4047dd4cbc9c8209027a48210a", async() => {
                BeginContext(1162, 6, true);
                WriteLiteral("Edytuj");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-userName", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 41 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Admin\Users.cshtml"
                                                                   WriteLiteral(user.UserName);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userName"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userName", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userName"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1172, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(1194, 117, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c968c2c31d4b4842a7f63eb0f7500dfa", async() => {
                BeginContext(1303, 4, true);
                WriteLiteral("Usuń");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-userName", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 42 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Admin\Users.cshtml"
                                                                       WriteLiteral(user.UserName);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userName"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userName", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userName"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1311, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 45 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Admin\Users.cshtml"
        }
    }

#line default
#line hidden
            BeginContext(1373, 297, true);
            WriteLiteral(@"</table>
<h2>Pracownicy</h2>
<table class=""table"" style=""background-color:azure"">

    <thead>
        <tr>
            <th>Użytkownik</th>
            <th>Email</th>
            <th>Telefon</th>
            <th>Imię</th>
            <th>Nazwisko</th>
            <th>
                ");
            EndContext();
            BeginContext(1670, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8467a7dc796e4eb7b11a6bd35ad5707d", async() => {
                BeginContext(1721, 16, true);
                WriteLiteral("Dodaj Pracownika");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1741, 52, true);
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n\r\n");
            EndContext();
#line 64 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Admin\Users.cshtml"
     foreach (var user in Model.ToList())
    {
        if (user.Role.ToArray().Contains("Employee"))
        {

#line default
#line hidden
            BeginContext(1909, 22, true);
            WriteLiteral("    <tr>\r\n        <td>");
            EndContext();
            BeginContext(1932, 13, false);
#line 69 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Admin\Users.cshtml"
       Write(user.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(1945, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(1965, 10, false);
#line 70 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Admin\Users.cshtml"
       Write(user.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1975, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(1995, 16, false);
#line 71 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Admin\Users.cshtml"
       Write(user.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(2011, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(2031, 14, false);
#line 72 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Admin\Users.cshtml"
       Write(user.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(2045, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(2065, 13, false);
#line 73 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Admin\Users.cshtml"
       Write(user.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(2078, 23, true);
            WriteLiteral("</td>\r\n        <!--<td>");
            EndContext();
            BeginContext(2102, 37, false);
#line 74 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Admin\Users.cshtml"
           Write(string.Join(",", user.Role.ToArray()));

#line default
#line hidden
            EndContext();
            BeginContext(2139, 36, true);
            WriteLiteral("</td>-->\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(2175, 116, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba2376ada3044fd3af58f2e45279bf48", async() => {
                BeginContext(2281, 6, true);
                WriteLiteral("Edytuj");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-userName", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 76 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Admin\Users.cshtml"
                                                           WriteLiteral(user.UserName);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userName"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userName", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userName"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2291, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(2305, 117, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e12935cf4594c59be398bf2186b836d", async() => {
                BeginContext(2414, 4, true);
                WriteLiteral("Usuń");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-userName", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 77 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Admin\Users.cshtml"
                                                               WriteLiteral(user.UserName);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userName"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userName", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userName"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2422, 28, true);
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n");
            EndContext();
#line 80 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Admin\Users.cshtml"
        }
    }

#line default
#line hidden
            BeginContext(2468, 304, true);
            WriteLiteral(@"</table>

<h2>Administratorzy</h2>
<table class=""table"" style=""background-color:azure"">

    <thead>
        <tr>
            <th>Użytkownik</th>
            <th>Email</th>
            <th>Telefon</th>
            <th>Imię</th>
            <th>Nazwisko</th>
            <th>
                ");
            EndContext();
            BeginContext(2772, 75, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49c95003f7f843b59c1848e5b4b75039", async() => {
                BeginContext(2823, 20, true);
                WriteLiteral("Dodaj administratora");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2847, 52, true);
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n\r\n");
            EndContext();
#line 100 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Admin\Users.cshtml"
     foreach (var user in Model.ToList())
    {
        if (user.Role.ToArray().Contains("Admin"))
        {

#line default
#line hidden
            BeginContext(3012, 22, true);
            WriteLiteral("    <tr>\r\n        <td>");
            EndContext();
            BeginContext(3035, 13, false);
#line 105 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Admin\Users.cshtml"
       Write(user.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(3048, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(3068, 10, false);
#line 106 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Admin\Users.cshtml"
       Write(user.Email);

#line default
#line hidden
            EndContext();
            BeginContext(3078, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(3098, 16, false);
#line 107 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Admin\Users.cshtml"
       Write(user.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(3114, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(3134, 14, false);
#line 108 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Admin\Users.cshtml"
       Write(user.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(3148, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(3168, 13, false);
#line 109 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Admin\Users.cshtml"
       Write(user.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(3181, 23, true);
            WriteLiteral("</td>\r\n        <!--<td>");
            EndContext();
            BeginContext(3205, 37, false);
#line 110 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Admin\Users.cshtml"
           Write(string.Join(",", user.Role.ToArray()));

#line default
#line hidden
            EndContext();
            BeginContext(3242, 36, true);
            WriteLiteral("</td>-->\r\n        <td>\r\n            ");
            EndContext();
            BeginContext(3278, 116, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53ed8925a03044d098638285290be9e7", async() => {
                BeginContext(3384, 6, true);
                WriteLiteral("Edytuj");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-userName", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 112 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Admin\Users.cshtml"
                                                           WriteLiteral(user.UserName);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userName"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userName", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userName"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3394, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(3408, 117, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e976f0fe66144c50b412d473b56f10e6", async() => {
                BeginContext(3517, 4, true);
                WriteLiteral("Usuń");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-userName", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 113 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Admin\Users.cshtml"
                                                               WriteLiteral(user.UserName);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userName"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userName", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userName"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3525, 28, true);
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n");
            EndContext();
#line 116 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Admin\Users.cshtml"
        }
    }

#line default
#line hidden
            BeginContext(3571, 16, true);
            WriteLiteral("</table>\r\n\r\n\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3605, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
#line 124 "D:\Informatyka\Studia\Praca dyplomowa\app\CarRental\CarRental\Views\Admin\Users.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
                BeginContext(3677, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CarRental.ViewModels.Admin.AdminUsersView>> Html { get; private set; }
    }
}
#pragma warning restore 1591
