﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using Pizza.Mvc;
    
    #line 1 "..\..\Views\Shared\Details.cshtml"
    using Pizza.Mvc.HtmlHelpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/Details.cshtml")]
    public partial class _Views_Shared_Details_cshtml : System.Web.Mvc.WebViewPage<Pizza.Contracts.Presentation.IDetailsModelBase>
    {
        public _Views_Shared_Details_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<h2>\r\n");

WriteLiteral("    ");

            
            #line 5 "..\..\Views\Shared\Details.cshtml"
Write(ViewBag.PageTitle);

            
            #line default
            #line hidden
WriteLiteral("\r\n</h2>\r\n\r\n<div>\r\n    <dl");

WriteLiteral(" class=\"dl-horizontal\"");

WriteLiteral(">\r\n");

WriteLiteral("        ");

            
            #line 10 "..\..\Views\Shared\Details.cshtml"
   Write(Html.ModelDisplay(Model));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </dl>\r\n</div>\r\n\r\n<p>\r\n");

WriteLiteral("    ");

            
            #line 15 "..\..\Views\Shared\Details.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

            
            #line default
            #line hidden
WriteLiteral("\r\n</p>\r\n");

        }
    }
}
#pragma warning restore 1591
