#pragma checksum "C:\Users\ferna\Desktop\SENAC\Projeto Integrador\Sabor Easy MVC\Views\Home\ConfContato.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23076f46e9222dcb3a64d5a5ec17b0eb2d15fc19"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ConfContato), @"mvc.1.0.view", @"/Views/Home/ConfContato.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23076f46e9222dcb3a64d5a5ec17b0eb2d15fc19", @"/Views/Home/ConfContato.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"caf070861fd063ef63cf09ee91994650b5f14371", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ConfContato : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Mensagem>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ferna\Desktop\SENAC\Projeto Integrador\Sabor Easy MVC\Views\Home\ConfContato.cshtml"
  
    ViewData["Title"] = "Contato";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3 style=\"margin-top: 20px;\">Olá <strong>");
#nullable restore
#line 6 "C:\Users\ferna\Desktop\SENAC\Projeto Integrador\Sabor Easy MVC\Views\Home\ConfContato.cshtml"
                                     Write(Model.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>, agradecemos por entrar em contato conosco!</h3>\r\n<p style=\"margin-top:20px;\">Aqui está o conteúdo da sua mensagem:</p>\r\n<p style=\"margin-top:20px;\"><Strong>Nome:</Strong> ");
#nullable restore
#line 8 "C:\Users\ferna\Desktop\SENAC\Projeto Integrador\Sabor Easy MVC\Views\Home\ConfContato.cshtml"
                                              Write(Model.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p style=\"margin-top:20px;\"><Strong>E-Mail:</Strong> ");
#nullable restore
#line 9 "C:\Users\ferna\Desktop\SENAC\Projeto Integrador\Sabor Easy MVC\Views\Home\ConfContato.cshtml"
                                                Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p style=\"margin-top:20px;\"><Strong>Mensagem</Strong> ");
#nullable restore
#line 10 "C:\Users\ferna\Desktop\SENAC\Projeto Integrador\Sabor Easy MVC\Views\Home\ConfContato.cshtml"
                                                 Write(Model.Msg);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Mensagem> Html { get; private set; }
    }
}
#pragma warning restore 1591
