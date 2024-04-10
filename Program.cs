// See https://aka.ms/new-console-template for more information
using Asset_Tracking_with_Entity_Framework;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Welcome to Asset Database!");

MyDbContext context = new MyDbContext();
List<Asset> assets;

MainMenu();

void MainMenu()
{
    //The main menu where the user chooses what to do.
    //Loops to let the user chose again whenever they've finished an action, until the user choses to exit the application.
    while (true)
    {
        int selection = OptionSelector.PickOption("\nWhat would you like to do?",
            [
                "Display List",
                "Add an asset",
                "Edit an asset",
                "Remove anasset",
                "Exit"
            ]);

        switch (selection)
        {
            case 1:
                ReadList();
                break;
            case 2:
                Add();
                break;

            case 3:
                Update();
                break;

            case 4:
                Delete();
                break;

            case 5:
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Thank you for using Asset Database!");
                Environment.Exit(0);
                break;
        }
    }
}

void ReadList()
{
    assets = context.Assets.Include(x => x.Office).OrderBy(x => x.Office.Name).ThenBy(a => a.PurchaseDate).ToList();

    Console.WriteLine("\n#   " + "TYPE".PadRight(16) + "MODEL".PadRight(16) + "OFFICE".PadRight(16) + "PURCHASE DATE".PadRight(16) +
                        "PRICE IN USD".PadRight(16) + "CURRENCY".PadRight(16) + "LOCAL PRICE".PadRight(16)  );
    Console.WriteLine("--------------------------------------------------------------------------------------------------------------");

    for (int i = 0; i< assets.Count; i++)
    {
        Asset a = assets[i];

        if (a.ExpiryDate < DateTime.Now.AddMonths(3)) Console.ForegroundColor = ConsoleColor.Red;
        else if (a.ExpiryDate < DateTime.Now.AddMonths(6)) Console.ForegroundColor = ConsoleColor.Yellow;

        string localPrice = (a.Price * a.Office.ConversionRate).ToString("n2");

        Console.WriteLine($"{i+1}".PadRight(4) + $"{a.Type}".PadRight(16) + a.Model.PadRight(16) + a.Office.Name.PadRight(16) + a.PurchaseDate.ToShortDateString().PadRight(16) +
                    $"{a.Price}".PadRight(16) + a.Office.Currency.PadRight(16) + localPrice);

        Console.ResetColor();
    }
}

void Add()
{
    Asset newAsset = new Asset();

    newAsset.Type = Asset.InputType();
    newAsset.Model = Asset.InputModel();
    newAsset.OfficeId = Asset.InputOffice();
    newAsset.PurchaseDate = Asset.InputDate();
    newAsset.Price = Asset.InputPrice();


    context.Assets.Add(newAsset);
    context.SaveChanges();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("The asset has been added to the database");
    Console.ResetColor();
}

void Update()
{
    //Let's the user update information on an existing asset.
    ReadList();
    Console.WriteLine("\nWhich asset would you like to update? Enter a number to choose an option");
    int number;
    while (true)
    {
        bool canParse = int.TryParse(Console.ReadLine(), out number);
        if (canParse && number <= assets.Count + 1) break;
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You did not enter a valid number. Try again!");
            Console.ResetColor();
        }
    }
    Asset selectedAsset = assets[number - 1];

    int selection = OptionSelector.PickOption("\nWhich information would you like to update",
        [
            "Device Type",
            "Model",
            "Office",
            "Purchase Date",
            "Price"
        ]);

    switch(selection)
    {
        case 1: selectedAsset.Type = Asset.InputType(); break;
        case 2: selectedAsset.Model = Asset.InputModel(); break;
        case 3: selectedAsset.OfficeId = Asset.InputOffice(); break;
        case 4: selectedAsset.PurchaseDate = Asset.InputDate(); break;
        case 5: selectedAsset.Price = Asset.InputPrice(); break;
    }
    context.Update(selectedAsset);
    context.SaveChanges();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("The asset has been updated");
    Console.ResetColor();
}

void Delete()
{
    //Lets the user delete an existing asset.
    ReadList();
    Console.WriteLine("\nWhich item would you like to delete? Enter a number to choose an option");
    int number;
    while (true)
    {
        bool canParse = int.TryParse(Console.ReadLine(), out number);

        if (canParse && number <= assets.Count + 1) break;

        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You did not enter a valid number. Try again!");
            Console.ResetColor();
        }
            
    }
    context.Assets.Remove(assets[number - 1]);
    context.SaveChanges();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("The asset has been deleted.");
    Console.ResetColor();
}
