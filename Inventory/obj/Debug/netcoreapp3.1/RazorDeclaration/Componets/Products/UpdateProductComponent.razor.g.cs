#pragma checksum "C:\Users\anton\OneDrive\Documentos\Documentos\Estudio\ASP.NET Core ft Blazor\Inventory\Inventory\Componets\Products\UpdateProductComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd93005cbfe5bc7d48db56656be30ff26f3862cd"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Inventory.Componets.Products
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\anton\OneDrive\Documentos\Documentos\Estudio\ASP.NET Core ft Blazor\Inventory\Inventory\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\anton\OneDrive\Documentos\Documentos\Estudio\ASP.NET Core ft Blazor\Inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\anton\OneDrive\Documentos\Documentos\Estudio\ASP.NET Core ft Blazor\Inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\anton\OneDrive\Documentos\Documentos\Estudio\ASP.NET Core ft Blazor\Inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\anton\OneDrive\Documentos\Documentos\Estudio\ASP.NET Core ft Blazor\Inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\anton\OneDrive\Documentos\Documentos\Estudio\ASP.NET Core ft Blazor\Inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\anton\OneDrive\Documentos\Documentos\Estudio\ASP.NET Core ft Blazor\Inventory\Inventory\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\anton\OneDrive\Documentos\Documentos\Estudio\ASP.NET Core ft Blazor\Inventory\Inventory\_Imports.razor"
using Inventory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\anton\OneDrive\Documentos\Documentos\Estudio\ASP.NET Core ft Blazor\Inventory\Inventory\_Imports.razor"
using Inventory.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\anton\OneDrive\Documentos\Documentos\Estudio\ASP.NET Core ft Blazor\Inventory\Inventory\_Imports.razor"
using Inventory.Componets.Ejercicios.BlazorPages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\anton\OneDrive\Documentos\Documentos\Estudio\ASP.NET Core ft Blazor\Inventory\Inventory\_Imports.razor"
using Inventory.Componets.Products;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\anton\OneDrive\Documentos\Documentos\Estudio\ASP.NET Core ft Blazor\Inventory\Inventory\_Imports.razor"
using Inventory.Componets.Storages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\anton\OneDrive\Documentos\Documentos\Estudio\ASP.NET Core ft Blazor\Inventory\Inventory\_Imports.razor"
using Inventory.Componets.InOut;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\anton\OneDrive\Documentos\Documentos\Estudio\ASP.NET Core ft Blazor\Inventory\Inventory\_Imports.razor"
using Inventory.Componets.Warehouse;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\anton\OneDrive\Documentos\Documentos\Estudio\ASP.NET Core ft Blazor\Inventory\Inventory\Componets\Products\UpdateProductComponent.razor"
using Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\anton\OneDrive\Documentos\Documentos\Estudio\ASP.NET Core ft Blazor\Inventory\Inventory\Componets\Products\UpdateProductComponent.razor"
using Bussines;

#line default
#line hidden
#nullable disable
    public partial class UpdateProductComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\Users\anton\OneDrive\Documentos\Documentos\Estudio\ASP.NET Core ft Blazor\Inventory\Inventory\Componets\Products\UpdateProductComponent.razor"
       
    [Parameter]
    public string IdProduct { get; set; }

    ProductEntity oProduct = new ProductEntity();
    List<CategoryEntity> categories = new List<CategoryEntity>();

    protected override async Task OnInitializedAsync()
    {
        categories = B_Category.ItemList();
        oProduct = B_Product.GetById(IdProduct);
    }

    public void UpdateProduct()
    {
        B_Product.UpdateItem(oProduct);
        NavManager.NavigateTo("product/list");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
    }
}
#pragma warning restore 1591