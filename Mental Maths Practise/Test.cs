using System.Diagnostics;

namespace Mental_Maths_Practise;

public class Test(int numberOfQuestions, int multiplierNumberOfDigits, int multiplicandNumberOfDigits)
{
    // Attributes
    private int TestScore { get; set; }
    private int[] Answers { get; } = new int[numberOfQuestions];
    private string[] Questions { get; } = new string[numberOfQuestions];
    private int MultiplierRange { get; } = (int)Math.Pow(10, multiplierNumberOfDigits); // stores the range of numbers the multiplier can be
    private int MultiplicandRange { get; } = (int)Math.Pow(10, multiplicandNumberOfDigits); // stores the range of numbers the multiplicand can be

    // Methods
    public void GenerateTest()
    {
        Random random = new Random(); // creates an instance of the Random class
        for (int i = 0; i < numberOfQuestions; i++)
        {
            int multiplicand = random.Next(1, MultiplicandRange); // generates a random number between 1 and multiplicand range
            int multiplier = random.Next(1, MultiplierRange); // generates a random number between 1 and multiplier range
            string question = $"{multiplicand} x {multiplier} = "; // creates the question for the user to see
            int answer = multiplicand * multiplier; // calculates the answer
            Questions[i] = question;
            Answers[i] = answer;
        }
        
    }

    public void RunTest()
    {
        Console.WriteLine("----------TEST STARTED----------");
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start(); // measures how long the test will take
        for (int i = 0; i < numberOfQuestions; i++)
        {
            Console.WriteLine("\n" + Questions[i]); // IMPORTANT BELOW 
            string? userInput = Console.ReadLine(); // gets the user's answer, accepts null as an input
            bool isANumber = int.TryParse(userInput, out int userAnswer); // trys to parse input into an int
            if (!isANumber) // if it can't be parsed, say the answer is wrong
            {
                Console.WriteLine("Incorrect");
            }
            else
            {
                if (userAnswer == Answers[i]) // if the answer is correct
                {
                    TestScore++; // add 1 to the score
                    Console.WriteLine("Correct!");
                
                }
                else // if the answer is wrong
                {
                    Console.WriteLine("Incorrect");
                }
            }
            
        }
        Console.WriteLine("----------TEST COMPLETED----------");
        stopwatch.Stop(); // stops the timer
        double testTime = Math.Round(stopwatch.Elapsed.TotalSeconds, 2); // stores how long the test took to 2dp
        Console.WriteLine("You scored " + TestScore + " out of " + numberOfQuestions + " and took " + testTime + " seconds"); // outputs the score
    }
    
    
    
    
}