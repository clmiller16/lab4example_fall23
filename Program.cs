//******Main *********//
int userChoice = GetMenuChoice(); 
Route(userChoice);

//******End Main *********//

static int GetMenuChoice(){
    DisplayMenu(); 
    string userChoice = Console.ReadLine();
    return int.Parse(userChoice);
}

static void DisplayMenu(){
    Console.Clear();
    Console.WriteLine("Enter 1 to purchase cheddar\nEnter 2 to purchase swiss\nEnter 3 to exit");
}

static void Route(int userChoice) {
    if (userChoice == 1) {
        AmericanCheese();
    }
    else if (userChoice == 2){
        SwissCheese();
    }
    else if (userChoice != 3)
        SayInvalid();
        PauseAction();
}

// Menu option 1 method
static void AmericanCheese(){
    Console.Clear();
    int rows = RandomNumber(3,9);
    for (int i=0; i < rows; i++){
        for (int j=0; j <= i; j++){
            Console.Write("o ");
        }
        Console.WriteLine();
    }
}

// Menu option 2 method
static void SwissCheese(){
    Console.Clear();
    Random rnd = new Random();
    int rows = RandomNumber(3, 9);
    Console.WriteLine("o"); //I'm hardcoding this for aesthetic purposes
    for (int i=1; i < rows; i++){
        for (int j=0; j<= i; j++){
            int oddsOfHole = RandomNumber(0, 100);
            if (oddsOfHole > 75){
                Console.Write("  ");
            }
            else {
                Console.Write("o ");
            }
        }
        Console.WriteLine();
    }
}

static int RandomNumber(int start, int end){
    Random rnd = new Random();
    return rnd.Next(start, end);
}

static void SayInvalid(){
    Console.WriteLine("Invalid. Please enter \"1\", \"2\", or \"3\"");
}

static void PauseAction(){
    Console.WriteLine("\nPress any key to continue...");
    Console.ReadKey();
}

