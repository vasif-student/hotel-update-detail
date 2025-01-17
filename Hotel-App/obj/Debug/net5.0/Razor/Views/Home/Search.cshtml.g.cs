#pragma checksum "C:\Users\HP\Desktop\Hotel-App\Hotel-App\Views\Home\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9864d44d7a0402b9eb818843d5dbe8e4b9c6946"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Search), @"mvc.1.0.view", @"/Views/Home/Search.cshtml")]
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
#line 1 "C:\Users\HP\Desktop\Hotel-App\Hotel-App\Views\_ViewImports.cshtml"
using Hotel_App;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\Desktop\Hotel-App\Hotel-App\Views\_ViewImports.cshtml"
using Hotel_App.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\Desktop\Hotel-App\Hotel-App\Views\_ViewImports.cshtml"
using Hotel_App.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HP\Desktop\Hotel-App\Hotel-App\Views\_ViewImports.cshtml"
using Hotel_App.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\HP\Desktop\Hotel-App\Hotel-App\Views\_ViewImports.cshtml"
using Hotel_App.Models.ViewModels.Hotel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9864d44d7a0402b9eb818843d5dbe8e4b9c6946", @"/Views/Home/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91c0919da7705681ff1011bc12c1c1670520f654", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Room>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\HP\Desktop\Hotel-App\Hotel-App\Views\Home\Search.cshtml"
  
    ViewData["Title"] = "Search";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\HP\Desktop\Hotel-App\Hotel-App\Views\Home\Search.cshtml"
 foreach (var room in Model)
{
    foreach (var image in room.RoomImages)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""hotel-masonry-grid-item hotel-masonry-grid-item-33 deluxe"">

            <!-- room card -->
            <div class=""hotel-room-card"">
                <div class=""hotel-cover-frame imgLoad"">
                    <a href=""roomSuite.html""><img class=""lozad"" data-src=""img/");
#nullable restore
#line 15 "C:\Users\HP\Desktop\Hotel-App\Hotel-App\Views\Home\Search.cshtml"
                                                                         Write(image.ImageName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" alt=""cover""></a>
                </div>
                <div class=""hotel-description-frame"">
                    <div class=""hotel-room-features"">
                        <div class=""hotel-feature imgLoad"">
                            <div class=""hotel-icon-frame""><img class=""lozad"" data-src=""img/icons/bed.svg"" alt=""icon""></div>
                            <span>");
#nullable restore
#line 21 "C:\Users\HP\Desktop\Hotel-App\Hotel-App\Views\Home\Search.cshtml"
                             Write(room.NumberOfAdult);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" Nəfərlik</span>
                        </div>
                        <div class=""hotel-feature imgLoad"">
                            <div class=""hotel-icon-frame""><img class=""lozad"" data-src=""img/icons/square.svg"" alt=""icon""></div>
                            <span>");
#nullable restore
#line 25 "C:\Users\HP\Desktop\Hotel-App\Hotel-App\Views\Home\Search.cshtml"
                             Write(room.Square);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        </div>\r\n                    </div>\r\n                    <a href=\"roomSuite.html\">\r\n                        <h3 class=\"hotel-mb-20\">");
#nullable restore
#line 29 "C:\Users\HP\Desktop\Hotel-App\Hotel-App\Views\Home\Search.cshtml"
                                           Write(room.RoomType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    </a>\r\n                    <div class=\"hotel-text-light hotel-text-sm hotel-mb-20\">");
#nullable restore
#line 31 "C:\Users\HP\Desktop\Hotel-App\Hotel-App\Views\Home\Search.cshtml"
                                                                       Write(room.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"hotel-card-bottom imgLoad\">\r\n                        <div class=\"hotel-price\">");
#nullable restore
#line 33 "C:\Users\HP\Desktop\Hotel-App\Hotel-App\Views\Home\Search.cshtml"
                                            Write(room.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" M <span>/gecə</span></div>
                        <a href=""roomSuite.html"" class=""hotel-btn""><img class=""lozad"" data-src=""img/icons/bookmark.svg"" alt=""icon"">Rezerv et</a>
                    </div>
                </div>
            </div>
            <!-- room card end -->

        </div>
");
#nullable restore
#line 41 "C:\Users\HP\Desktop\Hotel-App\Hotel-App\Views\Home\Search.cshtml"

    }
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Room>> Html { get; private set; }
    }
}
#pragma warning restore 1591
