using System;

class Program
{

    //List to store purchased products and their quantities
    static List<(string Product, int Quantity)> purchasedProducts = new List<(string Product, int Quantity)>();
    static void Main(string[] args)
    {
        Console.WriteLine("Hello user! Welcome to the E-commerce portal!");

        //Username and Password for login
        string username = "User";
        string password = "Welcome123";

        //Ask the user to enter username
        Console.WriteLine("Enter username: ");
        string inputusername = Console.ReadLine();

        //Ask the user to enter password
        Console.WriteLine("Enter password: ");
        string inputpassword = Console.ReadLine();

        //Check if the login credentials are correct
        if (inputusername == username && inputpassword == password)
        {
            Console.WriteLine("The login was successful. Please proceed.");

            //Moving to the next screen
            SecondScreen();
        }
        else
        {
            Console.WriteLine("The enterred credentials are incorrect. Please try again.");
        }
    }

    //Second screen - Product selection
    static void SecondScreen()
    {
        Console.WriteLine("List of available products:");
        Console.WriteLine("1. Apple");
        Console.WriteLine("2. Banana");
        Console.WriteLine("3. Mango");
        Console.WriteLine("4. Guava");

        Console.WriteLine("Enter the S.No. of the product you want to purchase: ");
        int selectedproduct = int.Parse(Console.ReadLine());

        string productname = "";

        switch (selectedproduct)
        {
            case 1:
                productname = "Apple";
                break;
            case 2:
                productname = "Banana";
                break;
            case 3:
                productname = "Mango";
                break;
            case 4:
                productname = "Guava";
                break;
            default:
                Console.WriteLine("Please enter valid selection.");
                return;
        }

        Console.WriteLine($"You selected {productname}.");

        //Moving to the third screen with the chosen product
        ThirdScreen(productname);
    }

    //Third screen - Quantity selection
    static void ThirdScreen(string selectedproduct)
    {
        //Asking the user to enter the quantity of the selected product
        Console.WriteLine($"Enter the required quantity of {selectedproduct}: ");
        int quantity = int.Parse(Console.ReadLine());

        Console.WriteLine($"You have selected {quantity} {selectedproduct}(s).");

        purchasedProducts.Add((selectedproduct, quantity));

        //Moving to the fourth screen
        FourthScreen();
    }

    //Fourth screen - Back to menu or Proceed to checkout
    static void FourthScreen()
    {
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1. Move to checkout");
        Console.WriteLine("2. Go back to product selection");

        Console.Write("Enter your choice: ");
        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            CheckoutScreen();
        }
        else if (choice == 2)
        {
            SecondScreen();
        }
        else
        {
            Console.WriteLine("Please enter a valid choice.");
        }
    }

    //Moving to the checkout screen
    static void CheckoutScreen()
    {
        Console.WriteLine("Proceeding to checkout. Please be patient.");

        FinalScreen();
    }

    //Final screen - List of purchased items
    static void FinalScreen()
    {
        Console.WriteLine("Purchased Products:");
        foreach (var item in purchasedProducts)
        {
            Console.WriteLine($"{item.Product}: {item.Quantity}");
        }
        Console.WriteLine("Thank you for ordering! Please come back soon!");
    }
}
