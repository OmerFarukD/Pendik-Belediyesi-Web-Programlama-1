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

Console.WriteLine(product);
