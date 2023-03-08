using System.Diagnostics.CodeAnalysis;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?"); //Output
            var firstName = Console.ReadLine(); // Input

            Console.WriteLine("What is your favorite color?"); //output
            var favoriteColor = Console.ReadLine(); //Input

            Console.WriteLine("What is your favorite animal?"); //output
            var favoriteAnimal = Console.ReadLine(); // Input

            Console.WriteLine("What is your favorite type of food?"); // output
            var favoriteFood = Console.ReadLine(); // Input

            Console.WriteLine($"My name is {firstName} and my favroite food is {favoriteFood}, even though it has been linked to the extinction of the common {favoriteColor} {favoriteAnimal}.");

            //end of assignment 1 
        }
        static int Math(int num1,int num2)
        {
            Console.WriteLine("Type a number");
           var test1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Type a 2nd number");
           var test2 = int.Parse(Console.ReadLine());


            Console.WriteLine(test1);
            Console.WriteLine(test2);



        }













    }
}
