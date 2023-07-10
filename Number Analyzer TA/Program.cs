using System.Security.Cryptography;

bool runProgram = true;
string name = null;
Console.WriteLine("Please enter your name.");
name= Console.ReadLine();
Console.WriteLine($"Welcome to the number analyzer, {name}");
while (runProgram)
{
    int num = 0;
    while (true)
    {
        Console.WriteLine($"{name}, please enter an integer between 1 and 100.");
        string input = Console.ReadLine();
        try
        {
            num = int.Parse(input);
            if(num < 1 || num > 100)
            {
                Console.WriteLine("Only use numbers between 1 and 100.");
            }
            else
            {
                Console.WriteLine("You entered the number " + num);
                break;
            }            
        }
        catch(FormatException)
        {
            Console.WriteLine("Only enter a whole number between 1 and 100 with no letters or symbols.");
        }
    }
    
    if(num < 60 && num%2 == 1)
    {
        Console.WriteLine("Odd and less than 60.");
    }else if(num <= 24 && num%2 == 0)
    {
        Console.WriteLine("Even and less than 25.");
    }else if(num <= 60 && num%2==0)
    {
        Console.WriteLine("Even and between 26 and 60.");
    }else if(num%2==0)
    {
        Console.WriteLine("Even and greater than 60.");
    }
    else
    {
        Console.WriteLine("Odd and greater than 60.");
    }

    while(true)
    {
        Console.WriteLine("Would you like to go again? y/n");
        string input = Console.ReadLine();
        if(input == "y")
        {
            break;
        }else if(input == "n")
        {
            Console.WriteLine("Thank you for using the number analyzer.");
            runProgram = false;
            break;
        }
        else
        {
            Console.WriteLine("Please only use a lower case y or n.");
        }
    }
    
    
}