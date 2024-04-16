// See https://aka.ms/new-console-template for more information
using CoffeeShop.PointOfSale.EntityFramework;
using Spectre.Console;
Console.WriteLine("Hello, World!");



var isRunning = true;
while (isRunning)
{
    var option = AnsiConsole.Prompt(
   new SelectionPrompt<MenuOptions>()
   .Title("What would you like to do?")
   .AddChoices(
       MenuOptions.AddProduct,
       MenuOptions.DeleteProduct,
       MenuOptions.UpdateProduct,
       MenuOptions.ViewAllProducts,
       MenuOptions.ViewProduct));

    switch (option)
    {
        case MenuOptions.AddProduct:
            ProductController.AddProduct();
            break;
        case MenuOptions.DeleteProduct:
            ProductController.DeleteProduct();
            break;
        case MenuOptions.UpdateProduct:
            ProductController.UpdateProduct();
            break;
        case MenuOptions.ViewAllProducts:
            ProductController.GetProductById();
            break;
        case MenuOptions.ViewProduct:
            ProductController.GetProducts();
            break;
    }

}


enum MenuOptions
{
    AddProduct,
    DeleteProduct,
    UpdateProduct,
    ViewProduct,
    ViewAllProducts,
    Quit
}

