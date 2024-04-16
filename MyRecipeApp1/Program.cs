namespace MyRecipeApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyRecipe myRecipe = new MyRecipe();
            bool exit = false;

            while (!exit)
            {
                // Display all the menu options
                Console.WriteLine("*********************************");
                Console.WriteLine("1. Enter recipe details");
                Console.WriteLine("2. Display recipe");
                Console.WriteLine("3. Scale recipe");
                Console.WriteLine("4. Reset quantities");
                Console.WriteLine("5. Clear all data");
                Console.WriteLine("6. Exit");
                Console.WriteLine("*********************************");

                int choice;
                bool validInput = int.TryParse(Console.ReadLine(), out choice);

                // Validate user input
                if (!validInput || choice < 1 || choice > 6)
                {
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 6.");
                    continue; // Restart the loop to show the options again
                }

                // Process user choice
                switch (choice)
                {
                    case 1:
                        myRecipe.EnterRecipeDetails(); // Enter recipe details
                        break;
                    case 2:
                        myRecipe.DisplayRecipe(); // Display recipe
                        break;
                    case 3:
                        myRecipe.ScaleRecipe(); // Scale recipe
                        break;
                    case 4:
                        myRecipe.ResetQuantities(); // Reset ingredient quantities
                        break;
                    case 5:
                        myRecipe.ClearData(); // Clear all recipe data
                        break;
                    case 6:
                        exit = true; // Exit the program
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 6.");
                        break;
                }
            }

            // Display exit message
            Console.WriteLine("Exiting RecipeApp. Press any key to close the program...");
            Console.ReadKey();
        }
    }
}
