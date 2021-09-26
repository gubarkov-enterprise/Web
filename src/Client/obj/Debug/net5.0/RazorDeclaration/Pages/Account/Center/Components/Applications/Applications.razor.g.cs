// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Web.Pages.Account.Center
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/hermann/RiderProjects/A-Project/Web/src/Client/_Imports.razor"
using AntDesign;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/hermann/RiderProjects/A-Project/Web/src/Client/_Imports.razor"
using AntDesign.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/hermann/RiderProjects/A-Project/Web/src/Client/_Imports.razor"
using AntDesign.ProLayout;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/hermann/RiderProjects/A-Project/Web/src/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/hermann/RiderProjects/A-Project/Web/src/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/hermann/RiderProjects/A-Project/Web/src/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/hermann/RiderProjects/A-Project/Web/src/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/hermann/RiderProjects/A-Project/Web/src/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/hermann/RiderProjects/A-Project/Web/src/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/hermann/RiderProjects/A-Project/Web/src/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/hermann/RiderProjects/A-Project/Web/src/Client/_Imports.razor"
using Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/hermann/RiderProjects/A-Project/Web/src/Client/_Imports.razor"
using Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/hermann/RiderProjects/A-Project/Web/src/Client/_Imports.razor"
using Web.Services;

#line default
#line hidden
#nullable disable
    public partial class Applications : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "/Users/hermann/RiderProjects/A-Project/Web/src/Client/Pages/Account/Center/Components/Applications/Applications.razor"
 

    private static readonly RenderFragment Download =

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.OpenElement(0, "AntDesign.Tooltip");
            __builder2.AddAttribute(1, "Title", 
#nullable restore
#line 37 "/Users/hermann/RiderProjects/A-Project/Web/src/Client/Pages/Account/Center/Components/Applications/Applications.razor"
                                                                                  "下载"

#line default
#line hidden
#nullable disable
            );
            __builder2.AddAttribute(2, "b-0pudmo2u4k");
            __builder2.AddMarkupContent(3, "\n    <Icon Type=\"download\" Theme=\"outline\" b-0pudmo2u4k></Icon>\n");
            __builder2.CloseElement();
        }
#nullable restore
#line 39 "/Users/hermann/RiderProjects/A-Project/Web/src/Client/Pages/Account/Center/Components/Applications/Applications.razor"
                    ;

private static readonly IList<RenderFragment> Actions = new List<RenderFragment>
{
        Download,

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.OpenElement(4, "AntDesign.Tooltip");
            __builder2.AddAttribute(5, "Title", 
#nullable restore
#line 44 "/Users/hermann/RiderProjects/A-Project/Web/src/Client/Pages/Account/Center/Components/Applications/Applications.razor"
                             "Edit"

#line default
#line hidden
#nullable disable
            );
            __builder2.AddAttribute(6, "b-0pudmo2u4k");
            __builder2.AddMarkupContent(7, "<Icon Type=\"edit\" Theme=\"outline\" b-0pudmo2u4k></Icon>");
            __builder2.CloseElement();
        }
#nullable restore
#line 44 "/Users/hermann/RiderProjects/A-Project/Web/src/Client/Pages/Account/Center/Components/Applications/Applications.razor"
                                                                                              ,

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.OpenElement(8, "AntDesign.Tooltip");
            __builder2.AddAttribute(9, "Title", 
#nullable restore
#line 45 "/Users/hermann/RiderProjects/A-Project/Web/src/Client/Pages/Account/Center/Components/Applications/Applications.razor"
                             "Share"

#line default
#line hidden
#nullable disable
            );
            __builder2.AddAttribute(10, "b-0pudmo2u4k");
            __builder2.AddMarkupContent(11, "<Icon Type=\"share-alt\" Theme=\"outline\" b-0pudmo2u4k></Icon>");
            __builder2.CloseElement();
        }
#nullable restore
#line 45 "/Users/hermann/RiderProjects/A-Project/Web/src/Client/Pages/Account/Center/Components/Applications/Applications.razor"
                                                                                                    ,

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.AddMarkupContent(12, "<Dropdown b-0pudmo2u4k><Icon Type=\"ellipsis\" Theme=\"outline\" b-0pudmo2u4k></Icon></Dropdown>\n");
        }
#nullable restore
#line 47 "/Users/hermann/RiderProjects/A-Project/Web/src/Client/Pages/Account/Center/Components/Applications/Applications.razor"
    };

        private static RenderFragment FormatWan(int val) {
            if (val > 10000) {
                val = (int) Math.Floor((double) val / 10000);
            }

            return 

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.OpenElement(13, "span");
            __builder2.AddAttribute(14, "b-0pudmo2u4k");
            __builder2.AddMarkupContent(15, "\n            ");
            __builder2.AddContent(16, 
#nullable restore
#line 55 "/Users/hermann/RiderProjects/A-Project/Web/src/Client/Pages/Account/Center/Components/Applications/Applications.razor"
             val

#line default
#line hidden
#nullable disable
            );
            __builder2.AddMarkupContent(17, "\n            ");
            __builder2.AddMarkupContent(18, "<span style=\"position: relative; top: -2px; font-size: 14px; font-style: normal; margin-left: 2px;\" b-0pudmo2u4k>万</span>\n        ");
            __builder2.CloseElement();
        }
#nullable restore
#line 57 "/Users/hermann/RiderProjects/A-Project/Web/src/Client/Pages/Account/Center/Components/Applications/Applications.razor"
               ;
 }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
