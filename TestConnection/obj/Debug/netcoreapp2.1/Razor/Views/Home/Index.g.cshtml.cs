#pragma checksum "C:\Users\ErnestoVM\Documents\Visual Studio 2017\Projects\TestConnection\TestConnection\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "907818e3132e6ab198b0d58caf8e58ffaa9d871c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\ErnestoVM\Documents\Visual Studio 2017\Projects\TestConnection\TestConnection\Views\_ViewImports.cshtml"
using TestConnection;

#line default
#line hidden
#line 2 "C:\Users\ErnestoVM\Documents\Visual Studio 2017\Projects\TestConnection\TestConnection\Views\_ViewImports.cshtml"
using TestConnection.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"907818e3132e6ab198b0d58caf8e58ffaa9d871c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca11356ec71a76d10063da721874b2255fc44095", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TestConnection.Models.Users>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 258, true);
            WriteLiteral(@"
<table class=""table table-hover"">
    <tr>
        <th
            ID USER
        </th>
        <th>
            USER
        </th>
        <th>
            MAIL
        </th>
        <th>
            PASSWORD
        </th>
        </tr>

");
            EndContext();
#line 19 "C:\Users\ErnestoVM\Documents\Visual Studio 2017\Projects\TestConnection\TestConnection\Views\Home\Index.cshtml"
     foreach (var Item in Model)
    {

#line default
#line hidden
            BeginContext(348, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(397, 41, false);
#line 23 "C:\Users\ErnestoVM\Documents\Visual Studio 2017\Projects\TestConnection\TestConnection\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => Item.IdUser));

#line default
#line hidden
            EndContext();
            BeginContext(438, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(494, 42, false);
#line 26 "C:\Users\ErnestoVM\Documents\Visual Studio 2017\Projects\TestConnection\TestConnection\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => Item.Usuario));

#line default
#line hidden
            EndContext();
            BeginContext(536, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(592, 40, false);
#line 29 "C:\Users\ErnestoVM\Documents\Visual Studio 2017\Projects\TestConnection\TestConnection\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => Item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(632, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(688, 45, false);
#line 32 "C:\Users\ErnestoVM\Documents\Visual Studio 2017\Projects\TestConnection\TestConnection\Views\Home\Index.cshtml"
           Write(Html.DisplayFor(modelItem => Item.Contraseña));

#line default
#line hidden
            EndContext();
            BeginContext(733, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(789, 57, false);
#line 35 "C:\Users\ErnestoVM\Documents\Visual Studio 2017\Projects\TestConnection\TestConnection\Views\Home\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { id = Item.IdUser }));

#line default
#line hidden
            EndContext();
            BeginContext(846, 20, true);
            WriteLiteral(" -\r\n                ");
            EndContext();
            BeginContext(867, 63, false);
#line 36 "C:\Users\ErnestoVM\Documents\Visual Studio 2017\Projects\TestConnection\TestConnection\Views\Home\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { id = Item.IdUser }));

#line default
#line hidden
            EndContext();
            BeginContext(930, 20, true);
            WriteLiteral(" -\r\n                ");
            EndContext();
            BeginContext(951, 61, false);
#line 37 "C:\Users\ErnestoVM\Documents\Visual Studio 2017\Projects\TestConnection\TestConnection\Views\Home\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id = Item.IdUser }));

#line default
#line hidden
            EndContext();
            BeginContext(1012, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 40 "C:\Users\ErnestoVM\Documents\Visual Studio 2017\Projects\TestConnection\TestConnection\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1055, 15, true);
            WriteLiteral("</table>\r\n   \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TestConnection.Models.Users>> Html { get; private set; }
    }
}
#pragma warning restore 1591
