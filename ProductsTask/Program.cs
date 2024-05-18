// See https://aka.ms/new-console-template for more information
using ProductsTask;

Product product = new("Pc", 1300m, ProductsTask.Type.Electronics);
Product product1 = new("Pc", 1300m, ProductsTask.Type.Electronics);
Product product2 = new("Dune", 16m, ProductsTask.Type.Books);
Product product3= new("Shirt", 25m, ProductsTask.Type.Clothing);

ProductCatalog catalog = new();
catalog.AddToCatalog(product, product1, product2, product3);

catalog.GetAllProductsByType(ProductsTask.Type.Electronics);
