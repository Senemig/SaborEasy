#pragma checksum "C:\Users\ferna\Desktop\SENAC\Projeto Integrador\Sabor Easy MVC\Views\Home\ListaMensagens.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0eca070a9eb43ad21a2d40f43a18df9e3e9d92ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ListaMensagens), @"mvc.1.0.view", @"/Views/Home/ListaMensagens.cshtml")]
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
#line 1 "C:\Users\ferna\Desktop\SENAC\Projeto Integrador\Sabor Easy MVC\Views\_ViewImports.cshtml"
using Sabor_Easy_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ferna\Desktop\SENAC\Projeto Integrador\Sabor Easy MVC\Views\_ViewImports.cshtml"
using Sabor_Easy_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0eca070a9eb43ad21a2d40f43a18df9e3e9d92ee", @"/Views/Home/ListaMensagens.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"caf070861fd063ef63cf09ee91994650b5f14371", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ListaMensagens : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Mensagem>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ferna\Desktop\SENAC\Projeto Integrador\Sabor Easy MVC\Views\Home\ListaMensagens.cshtml"
  
    ViewData["Title"] = "Mensagens";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"blog-wrapper\">\r\n\r\n");
#nullable restore
#line 8 "C:\Users\ferna\Desktop\SENAC\Projeto Integrador\Sabor Easy MVC\Views\Home\ListaMensagens.cshtml"
     if (Model.Count > 0)
    {
        for (int i = Model.Count - 1; i >= 0; i--)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"blog-card\">\r\n                <div class=\"blog-card-body\">\r\n                    <p class=\"blog-title\">");
#nullable restore
#line 14 "C:\Users\ferna\Desktop\SENAC\Projeto Integrador\Sabor Easy MVC\Views\Home\ListaMensagens.cshtml"
                                     Write(Model[i].nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"blog-title\">");
#nullable restore
#line 15 "C:\Users\ferna\Desktop\SENAC\Projeto Integrador\Sabor Easy MVC\Views\Home\ListaMensagens.cshtml"
                                     Write(Model[i].email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"blog-description\">");
#nullable restore
#line 16 "C:\Users\ferna\Desktop\SENAC\Projeto Integrador\Sabor Easy MVC\Views\Home\ListaMensagens.cshtml"
                                           Write(Model[i].mensagem);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"blog-date\">Enviada em ");
#nullable restore
#line 17 "C:\Users\ferna\Desktop\SENAC\Projeto Integrador\Sabor Easy MVC\Views\Home\ListaMensagens.cshtml"
                                               Write(Model[i].msgDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 20 "C:\Users\ferna\Desktop\SENAC\Projeto Integrador\Sabor Easy MVC\Views\Home\ListaMensagens.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Mensagem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
