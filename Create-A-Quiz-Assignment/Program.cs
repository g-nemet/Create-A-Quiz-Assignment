// Create a Quiz Assignment by Gabriel N.
#nullable disable
Console.Clear();

// WELCOME
Console.WriteLine("Welcome to the Marvel Cinematic Universe Quiz!");

// Questions
// score count
int score = 0;

// Question 1
Console.WriteLine("\n1. What Realm is Thor from?");
string answer1 = Console.ReadLine().ToLower();
if (answer1 == "asgard") {
    Console.WriteLine("Correct!");
    score++;
}  else {
    Console.WriteLine("Incorrect!");
}

// Question 2
Console.WriteLine("\n2. What is Iron Man's real name?");
string answer2 = Console.ReadLine().ToLower();
if (answer2 == "tony stark") {
    Console.WriteLine("Correct!");
    score++;
}  else {
    Console.WriteLine("Incorrect!");
}

// Question 3
Console.WriteLine("\n3. Originally, there were how many Avengers?");
string answer3 = Console.ReadLine().ToLower();
if (answer3 == "6" || answer3 == "six") {
    Console.WriteLine("Correct!");
    score++;
}  else {
    Console.WriteLine("Incorrect!");
}

// Question 4
Console.WriteLine("\n4. What actor plays The Hulk/Bruce Banner in the film 'The Incredible Hulk'?");
string answer4 = Console.ReadLine().ToLower();
if (answer4 == "edward norton" || answer4 == "ed norton") {
    Console.WriteLine("Correct!");
    score++;
}  else {
    Console.WriteLine("Incorrect!");
}

// RESULTS
Console.WriteLine("\nYOUR RESULTS:");

if (score == 0) {
    Console.WriteLine("0 / 4 (0%)");
    Console.WriteLine("Better luck next time!");
} else if (score == 1) {
    Console.WriteLine("1 / 4 (25%)");
    Console.WriteLine("Uh Oh!"); 
} else if (score == 2) {
    Console.WriteLine("2 / 4 (50%)");
    Console.WriteLine("Not Great!");
} else if (score == 3) {
    Console.WriteLine("3 / 4 (75%)");
    Console.WriteLine("Almost There!");
} else if (score == 4) {
    Console.WriteLine("4 / 4 (100%)");
    Console.WriteLine("Great Job!");
}