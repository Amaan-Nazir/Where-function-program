using System;
using System.Collections.Generic;
using System.Linq;

//Additional Functionality: 
// Allowed the user to search by more than just underscore (including numbers, dashes etc.)
// Allowed the user to filter by minimum length usernames
// Allowed the user to filter by maximum length usernames

List<string> UserName = new List<string> { "Amaan123", "Machhh" , "Amaan_Naz_ir" , "Amaan_Naz" , "Ish123" , "Ahmed_saeed" , "Nazir_Amaan"  , "MuhammadIsh" , "Ishy_G" , "A-Naz" , "J-Hufford"};

while (true)
{
    Console.WriteLine("The current usernames are: ");
    Console.WriteLine();

    foreach (var name in UserName)
    {
        Console.WriteLine(name);
    }

    Console.WriteLine();

    Console.WriteLine("Please press U follwed by enter to display usernames containing an underscore :) ");
    Console.WriteLine("Please press D follwed by enter to display usernames containing a dash :) ");
    Console.WriteLine("Please press N follwed by enter to display usernames containing numbers :) ");

    Console.WriteLine();

    Console.WriteLine("Please type max followed by enter to display username with the MOST characters :) ");
    Console.WriteLine("Please type min followed by enter to display the username with the LEAST characters :)");

    Console.WriteLine();
    Console.WriteLine("Press 0 to END the programme");

    Console.WriteLine();

    var user = Console.ReadLine();

    Console.WriteLine();

    if (user == "U" || user == "u")
    {
        IEnumerable<string> Underscore = UserName.Where<string>(underScore => underScore.Contains("_"));

        foreach (var U in Underscore)
        {
            Console.WriteLine(U);
        }

    }
    else if (user == "D" || user == "d") //Additional functionality (filter by dash)
    {
        IEnumerable<string> Dash = UserName.Where<string>(dash => dash.Contains("-"));

        foreach (var D in Dash)
        {
            Console.WriteLine(D);
        }
    }
    else if (user == "N" || user == "n") //Additional functionality (filter by number)
    {

        IEnumerable<string> Number = UserName.Where<string>(num => num.Contains("1") || num.Contains("2") || num.Contains("3"));

        foreach (var Num in Number)
        {
            Console.WriteLine(Num);
        }
    }
    else if (user == "Max" || user == "max" || user == "MAX") //additional functionality
    {
        IEnumerable<string> MaxLength = UserName.Where<string>(Most => Most.Length > 11);
        
        foreach (var M in MaxLength)
        {
            Console.WriteLine(M);
        }

    }
    else if (user == "Min" || user == "min" || user == "MIN") // additional functionality
    {
        IEnumerable<string> MinLength = UserName.Where<string>(Smallest => Smallest.Length < 6);

        foreach (var m in MinLength)
        {
            Console.WriteLine(m);
        }
    }
    else if(user == "0")
    {
        break;
    }
    else
    {
        Console.WriteLine("Sorry That is not a valid option.");
    }
    Console.ReadLine();
    Console.Clear();
}
