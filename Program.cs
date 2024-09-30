
string userInput= "";

while (userInput != "4")
        {
            userInput = GetMenuChoice();
            if (userInput == "1")
            {
                PlainPizza();
                
            }
            else if (userInput == "2")
            {
                CheesePizza(); 
                
            }
            else if (userInput == "3")
            {
                PepPizza();
               
            }
            else if (userInput == "4")
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid Choice");
                return;
            }
        }


static string GetMenuChoice(){
    DisplayMenu();
    return Console.ReadLine();
}

static void DisplayMenu(){
    System.Console.WriteLine("Welcome to Crimson Crust! Where the crust is the best part of the Pizza!");
    System.Console.WriteLine("1:  Get Plain Pizza");
    System.Console.WriteLine("2:  Get Cheese Pizza");
    System.Console.WriteLine("3:  Get Pepperoni Pizza");
    System.Console.WriteLine("4:  Exit");
}








static void PlainPizza() {
    //Random generator
  Random rand = new Random();
  int rows = rand.Next(8, 13); 
        
        // Display the plain pizza
        for (int i = rows; i > 0; i--)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine(); 
        }
    Console.Write("Here's your Slice of Cheese Pizza!\n");
     
     
    }

 



static void CheesePizza() {
 //Random number generator
 Random rand = new Random();
    int rows = rand.Next(8, 13);  

    for (int i = rows; i >= 1; i--)
    {
        if (i == rows)
        {
            // Print the top row with *
            for (int j = 0; j < rows; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();  
        }
        else
        {
            // First * in the rows
            Console.Write("*");  

            // Print middle characters with #
            for (int j = 1; j < i - 1; j++)
            {
                Console.Write("#");
            }

            // Print the last * for the rows
            if (i > 1)
            {
                Console.Write("*");
            }

            Console.WriteLine();  // Move to the next line after printing the current row
        }
    }

    Console.WriteLine("Here's your Slice of Cheese Pizza!\n");
}

static void PepPizza(){
//Random number generator
Random rand = new Random();
int rows = rand.Next(8, 13);
        
        
        for (int i = rows; i >= 0; i--)
        {
            if (i == 0)
            {
                
                Console.WriteLine("**");
                Console.WriteLine("*");
            }
            else if (i == rows)
            {
                for (int j = 0; j < i + 2; j++)  
                    {
                        Console.Write("*");
                    }
                Console.WriteLine();  
            }
            else
            {
            
                Console.Write("*");  
                for (int j = 0; j < i; j++)
                {
                    // Randomly place pepperoni slices
                    if (rand.Next(5) == 0)
                    {
                        // Pepperoni
                        Console.Write("[]");  
                    }
                    else
                    {
                        // Cheese
                        Console.Write("#");  
                    }
                }
                Console.WriteLine("*");  
            }   
        }


        Console.WriteLine("Here's your Slice of Pepperoni Pizza!\n");
}