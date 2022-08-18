/*******************************************************************************************************************************************/

// 03_Week_02_Lab : Movie Database

/*******************************************************************************************************************************************/



Console.WriteLine("********************************************");

Console.WriteLine("Welcome to the Grand Circus Movie Database!");

Console.WriteLine("********************************************");



List<MovieClass> movieList = new List<MovieClass>();   //create a movie list



movieList.Add(new MovieClass("The Shawshank Redemption", "Drama"));

movieList.Add(new MovieClass("The Godfather", "Drama"));

movieList.Add(new MovieClass("The Dark Knight", "Superhero"));

movieList.Add(new MovieClass("Return of the King", "Fantasy"));

movieList.Add(new MovieClass("Fellowship of the Ring", "Fantasy"));

movieList.Add(new MovieClass("Empire Strikes Back", "SciFi"));

movieList.Add(new MovieClass("Interstellar", "SciFi"));

movieList.Add(new MovieClass("Superman", "Superhero"));

movieList.Add(new MovieClass("Avengers", "Superhero"));

movieList.Add(new MovieClass("The Matrix", "SciFi"));



bool keepGoing = true;

while (keepGoing)

{

    Console.WriteLine($"There are {movieList.Count} Movie(s) in the list!"); //display the movie count 

    Console.WriteLine("\nCategories:");

    Console.WriteLine("==============");



    List<string> categoryList = new List<string>(); //create a category list with numbers



    foreach (MovieClass next in movieList)

    {

        if (categoryList.IndexOf(next.Category) == -1)

        {

            categoryList.Add(next.Category);

        }

    }



    int i = 1;

    foreach (string item in categoryList)  // display the all category list  

    {

        Console.WriteLine($"{i}. {item}");

        i++;

    }



    bool validInput = true;

    while (validInput)

    {

        Console.Write("\nPlease, enter the Category number you are interested in: "); //promp user enter input

        int input;

        bool isInput = int.TryParse(Console.ReadLine(), out input);



        if (isInput && input > 0 && input <= categoryList.Count)  //validate the users input

        {

            foreach (MovieClass next in movieList)

            {

                if (next.Category == categoryList[input - 1])

                {

                    Console.WriteLine($"{next}");

                }

            }

            validInput = false;

        }

        else

        {

            Console.WriteLine("\nSorry, invalid entry!"); // invalid input

            validInput = true;

        }

    }



    bool validEntry = true;

    while (validEntry)

    {

        Console.Write("\nWould you like to go again? Please, enter 'y' or 'n': "); // ask the user if wants to continue

        string entry = Console.ReadLine();



        if (entry == "y" || entry == "yes")

        {

            validEntry = false;

            keepGoing = true;

        }

        else if (entry == "n" || entry == "no")

        {

            validEntry = false;

            keepGoing = false;

        }

        else

        {

            Console.WriteLine("\nSorry, invalid entry!");

            validEntry = true;

        }

    }

}



Console.WriteLine("\nThanks for using the Grand Circus Movie Database!");



public class MovieClass     //build Movie class - with 2 member string variables (Title and Category)

{

    public string Title;

    public string Category;



    public MovieClass(string _Title, string _Category) //create a constructor - Title and Category as parameters

    {

        Title = _Title;

        Category = _Category;

    }

    public override string ToString()

    {

        return $"Title is {Title}, Category is {Category}";

    }



}

