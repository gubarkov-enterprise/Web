// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Web.Pages.Dashboard.Monitor
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
#line 13 "/Users/hermann/RiderProjects/A-Project/Web/src/Client/_Imports.razor"
using Web.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/hermann/RiderProjects/A-Project/Web/src/Client/Pages/Dashboard/Monitor/Components/Charts/Map/MiniArea.razor"
using Web.Models;

#line default
#line hidden
#nullable disable
    public partial class MiniArea : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "/Users/hermann/RiderProjects/A-Project/Web/src/Client/Pages/Dashboard/Monitor/Components/Charts/Map/MiniArea.razor"
 
    private IChartComponent _chart;

    private readonly AreaConfig _chartConfig = new AreaConfig
    {
        XField = "x",
        YField = "y",
        Height = 84,
        Padding = new[] { 8, 8, 8, 8 },
        ForceFit = true,
        XAxis = new ValueCatTimeAxis
        {
            Visible = false
        },
        YAxis = new ValueAxis
        {
            Visible = false
        }
    };

    [Parameter]
    public ChartDataItem[] Data { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
