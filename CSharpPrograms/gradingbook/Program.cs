using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gradingbook
{
    class Program
    {
        static string name;
        static void Main(string[] args)
        {
            
            //BUILD DICTIONARY
            Dictionary<string, string> Gradebook = new Dictionary<string, string>();

            while (name != "quit")
            {

                string quit = "quit";

                Console.WriteLine("This is your gradebook. Enter student's name or 'quit' to finish");
                string grades = " ";
                name = Console.ReadLine();

                if (name.ToLower() == quit)

                {
                    break; // Stop gathering names/array  - SKIPS TO FOR EACH 
                }
                                                           
                 //ASK FOR STUDENT'S GRADE
                Console.WriteLine("Enter {0}'s grades, separated by a blank space only. Or type 'quit' to stop.", name);
                grades = Console.ReadLine();
                // adding to dictionary
                Gradebook.Add(name, grades);
                Console.Clear(); //clears board
                                              

                }

                Console.Clear();

            foreach (var name in Gradebook.Keys) //creating calculation for each student 
            {
                // Split Strings
                string[] gradesSplit = Gradebook[name].Split(' '); // Splits at spaces in b/w numbers
                //convert to numbers
                int[] grades2nums = Array.ConvertAll(gradesSplit, int.Parse); // make into INTegers
                //find highest grade
                int highestGrade = grades2nums.Max();
                //lowest grade
                int lowestGrade = grades2nums.Min();
                //average grade
                double avgGrade = grades2nums.Average();
                // all of calculations for student
                Console.WriteLine("Student: " + name);
                Console.WriteLine("Highest Grade: " + highestGrade);
                Console.WriteLine("Lowest Grade: " + lowestGrade);
                Console.WriteLine("Avg Grade: " + avgGrade);
                Console.WriteLine("------");



            }

            Console.Read();

            }
                                                    
          
        }
    }
    





                //ASK USER'S CHOICE AGAIN

/*foreach (var name in studentGrades.Keys)
{
    string g = studentGrades[i];
    Console.WriteLine($"Name: {i});
}

}





// now the user entered 'quit', we need to calculate the grades
//we need to loop through the studentGrades dictionary
/*for each (var name in studentGrades.Keys)
{
sName = 1;
sGrades = studentGrades[i]; // it is like "100 99 98 95"
arrayGrades = sGrades.Split(' ');

iGrades = Array.ConvertAll(arrayGrades, int.Parse);
}*/
   