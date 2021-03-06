#pragma checksum "C:\Users\anton\OneDrive\Documentos\Documentos\Estudio\ASP.NET Core ft Blazor\Inventory\Inventory\Componets\InOut\CreateInOputComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02983d26d609f28c526943937e6a346f4d831d90"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Inventory.Componets.InOut
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
#line 1 "C:\Users\anton\OneDrive\Documentos\Documentos\Estudio\ASP.NET Core ft Blazor\Inventory\Inventory\Componets\InOut\CreateInOputComponent.razor"
using Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\anton\OneDrive\Documentos\Documentos\Estudio\ASP.NET Core ft Blazor\Inventory\Inventory\Componets\InOut\CreateInOputComponent.razor"
using Bussines;

#line default
#line hidden
#nullable disable
    public partial class CreateInOputComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 40 "C:\Users\anton\OneDrive\Documentos\Documentos\Estudio\ASP.NET Core ft Blazor\Inventory\Inventory\Componets\InOut\CreateInOputComponent.razor"
       
    InputOutputEntity oInputOutput = new InputOutputEntity();

    List<WarehouseEntity> warehouses = new List<WarehouseEntity>();
    List<StorageEntity> storages = new List<StorageEntity>();

    ProductEntity oProduct = new ProductEntity();
    StorageEntity oStorage = new StorageEntity();

    string message = "";

    string buttonValue => oInputOutput.IsInput ? "Registrar Entrada" : "Registrar Salida";
    protected override async Task OnInitializedAsync()
    {
        warehouses = B_Warehouse.ItemList();
    }

    private void OnChangedWarehouse(ChangeEventArgs e)
    {
        var idWarehouse = e.Value.ToString();

        storages = B_Storage.GetStorageProductByWarehouse(idWarehouse);
    }

    private void SaveInOput()
    {
        oStorage = storages.LastOrDefault(s => s.StorageId == oInputOutput.StorageId);
        oProduct = oStorage.Product;

        if (oInputOutput.IsInput)
        {
            oStorage.PartialQuantity = oStorage.PartialQuantity + oInputOutput.Quantity;
            B_Storage.UpdateItem(oStorage);

            oProduct.TotalQuantity = oProduct.TotalQuantity + oInputOutput.Quantity;
            B_Product.UpdateItem(oProduct);
            message = $" El producto {oProduct.ProductName} ha sido actualizado";
        }
        else
        {
            if (IsBiggerthanZero(oInputOutput.Quantity, oStorage.PartialQuantity))
            {
                oStorage.PartialQuantity = oStorage.PartialQuantity - oInputOutput.Quantity;
                B_Storage.UpdateItem(oStorage);

                oProduct.TotalQuantity = oProduct.TotalQuantity - oInputOutput.Quantity;
                B_Product.UpdateItem(oProduct);
            }
            else {
                message = $"No existe sufuciente la cantidad suficiente en bodega para el producto {oProduct.ProductName} ";
            }

        }
    }

    private bool IsBiggerthanZero(int quantity, int storageQuantity)
    {
        if (storageQuantity > quantity)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
