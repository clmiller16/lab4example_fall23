//Come up with a menu driven system that will allow a user to choose 1 of 3 options

//******Main *********//
int userChoice = GetMenuChoice(); 

while(userChoice != 3){
    Route(userChoice);
    userChoice = GetMenuChoice();
}
//******End Main *********//

static int GetMenuChoice(){
    DisplayMenu(); 
    string userChoice = Console.ReadLine();
    if (IsValidChoice(userChoice)) {
        return int.Parse(userChoice);
    }
    else return 0;
}

static void DisplayMenu(){
    Console.Clear();
    Console.WriteLine("Enter 1 to purchase cheddar\nEnter 2 to purchase swiss\nEnter 3 to exit");
}

static bool IsValidChoice(string userChoice) {
    if (userChoice == "1" || userChoice == "2" || userChoice == "3") {
        return true;
    }
    return false;
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
    Random rnd = new Random();
    int number = rnd.Next(3, 10);
    for (int i=0; i < number; i++){
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
    int number = rnd.Next(3, 10);
    Console.WriteLine("o"); //I'm hardcoding this for aesthetic purposes
    for (int i=1; i < number; i++){
        for (int j=0; j<= i; j++){
            Random rand = new Random();
            int rNumber = rand.Next(100);
            if (rNumber > 75){
                Console.Write("  ");
            }
            else {
                Console.Write("o ");
            }
        }
        Console.WriteLine();
    }
}

static void SayInvalid(){
    Console.WriteLine("Invalid. Please enter \"1\", \"2\", or \"3\"");
}

static void PauseAction(){
    Console.WriteLine("\nPress any key to continue...");
    Console.ReadKey();
}