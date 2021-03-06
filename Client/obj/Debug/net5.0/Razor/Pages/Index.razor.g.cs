#pragma checksum "C:\Proyecto2\BlazorPeliculas\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0af4ad2f142d74ece7d746d57683f7c7274c80e1"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorPeliculas.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Proyecto2\BlazorPeliculas\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Proyecto2\BlazorPeliculas\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Proyecto2\BlazorPeliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Proyecto2\BlazorPeliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Proyecto2\BlazorPeliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Proyecto2\BlazorPeliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Proyecto2\BlazorPeliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Proyecto2\BlazorPeliculas\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Proyecto2\BlazorPeliculas\Client\_Imports.razor"
using BlazorPeliculas.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Proyecto2\BlazorPeliculas\Client\_Imports.razor"
using BlazorPeliculas.Shared.Entidades;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Proyecto2\BlazorPeliculas\Client\_Imports.razor"
using BlazorPeliculas.Client.Repositorios;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Proyecto2\BlazorPeliculas\Client\_Imports.razor"
using BlazorPeliculas.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Proyecto2\BlazorPeliculas\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Proyecto2\BlazorPeliculas\Client\_Imports.razor"
using BlazorPeliculas.Shared.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Proyecto2\BlazorPeliculas\Client\Pages\Index.razor"
using BlazorPeliculas.Client.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Proyecto2\BlazorPeliculas\Client\Pages\Index.razor"
using BlazorPeliculas.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Proyecto2\BlazorPeliculas\Client\Pages\Index.razor"
using BlazorPeliculas.Client.Pages;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/index")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.OpenComponent<BlazorPeliculas.Client.Components.HeaderComponent>(1);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(2, "\n");
            __builder.OpenElement(3, "div");
            __builder.AddMarkupContent(4, "<h3>En Cartelera</h3>\n    ");
            __builder.OpenComponent<BlazorPeliculas.Client.Shared.ListadoPeliculas>(5);
            __builder.AddAttribute(6, "Peliculas", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<BlazorPeliculas.Shared.Entidades.Pelicula>>(
#nullable restore
#line 14 "C:\Proyecto2\BlazorPeliculas\Client\Pages\Index.razor"
                                 EnCartelera

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\n\n");
            __builder.OpenElement(8, "div");
            __builder.AddMarkupContent(9, "<h3>Pr??ximos Estrenos</h3>\n    ");
            __builder.OpenComponent<BlazorPeliculas.Client.Shared.ListadoPeliculas>(10);
            __builder.AddAttribute(11, "Peliculas", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<BlazorPeliculas.Shared.Entidades.Pelicula>>(
#nullable restore
#line 19 "C:\Proyecto2\BlazorPeliculas\Client\Pages\Index.razor"
                                 FuturosEstrenos

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\n\n");
            __builder.OpenElement(13, "div");
            __builder.OpenComponent<BlazorPeliculas.Client.Components.FooterComponent>(14);
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "C:\Proyecto2\BlazorPeliculas\Client\Pages\Index.razor"
       
    private List<Pelicula> FuturosEstrenos;
    private List<Pelicula> EnCartelera;

    protected async override Task OnInitializedAsync()
    {
        var httpResponse = await repositorio.Get<HomePageDTO>("api/peliculas");
        FuturosEstrenos = httpResponse.Response.ProximosEstrenos;
        EnCartelera = httpResponse.Response.PeliculasEnCartelera;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepositorio repositorio { get; set; }
    }
}
#pragma warning restore 1591
