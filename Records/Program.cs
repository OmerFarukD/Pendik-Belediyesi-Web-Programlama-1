using Records;


Category category = new Category(
    1, "Bilgisayar", "Bilgisayar açıklaması");

Product product = new Product(
    Name: "Msi Bravo A15",
    Description: "Msi bilgisayar anlatmaya gerek yok",
    Price: 25000,
    Stock: 250,
    Category: category
    );

Product[] products = {product, new Product(
    Name: "Msi Bravo A14",
    Description: "Msi bilgisayar anlatmaya gerek yok 1",
    Price: 15000,
    Stock: 50,
    Category: category
    ),
};

//Array.ForEach(products, x =>
//{
//    Console.WriteLine(x);
//});

foreach (Product item in products)
{
    Console.WriteLine(item);
}


