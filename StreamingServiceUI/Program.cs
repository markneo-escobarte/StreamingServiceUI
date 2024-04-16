using StreamingServiceBL;
using StreamingServiceDL;

namespace StreamingServiceUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("Welcome to Marvel Assemble!");
            Console.WriteLine("Binge Worthy Marvel Cinematic Universe Movies Below!");
            Console.WriteLine(""); ;

            Console.Write("Enter your username: ");
            string Username = Console.ReadLine();

            Console.Write("Enter your password: ");
            string Password = Console.ReadLine();


            MovieBL movieBL = new MovieBL();
            bool result = movieBL.VerifyUser(Username, Password);

            if (result)
            {
                Console.WriteLine("-----------------------------------------------------"); ;
                Console.WriteLine("Welcome Back, " + Username);
                Console.WriteLine("");
                Console.WriteLine("Enter the movie code of the movie you want to watch:");
                Console.WriteLine("M1 Avengers: Endgame");
                Console.WriteLine("M2 Avengers:  Infinity War");
                Console.WriteLine("M3 Black Panther");
                Console.WriteLine("M4 The Avengers");
                Console.WriteLine("M5 Avengers: Age of Ultron");
                Console.WriteLine("M6 Iron Man 3");
                Console.WriteLine("M7 Captain America: Civil War");
                Console.WriteLine("M8 Spider-Man: Homecoming");
                Console.WriteLine("M9 Guardians of the Galaxy Vol. 2");
                Console.WriteLine("M10 Thor: Ragnarok ");
                Console.WriteLine("");

            }

            else
            {
                Console.WriteLine("It seems the username or password that you input is invalid.");
            }

           

                Console.Write("Enter a movie code here: ");
                string code = Console.ReadLine();

            switch (code)

            {
                case "M1":
                        MovieDL.Movie1(code);
                    break;

                case "M2":
                        MovieDL.Movie2(code);
                    break;

                case "M3":

                 MovieDL.Movie3(code);
                    break;

                case "M4":

                    MovieDL.Movie4(code);
                    break;

                case "M5":

                    MovieDL.Movie5(code);
                    break;

                case "M6":

                    MovieDL.Movie6(code);
                    break;

                case "M7":

                    MovieDL.Movie7(code);
                    break;

                case "M8":

                    MovieDL.Movie8(code);
                    break;

                case "M9":

                    MovieDL.Movie9(code);
                    break;

                case "M10":

                    MovieDL.Movie10(code);
                    break;

                default:
                    Console.WriteLine("It seems the code that you input is invalid.");
                    break;
            }

             
        }
    }
}
