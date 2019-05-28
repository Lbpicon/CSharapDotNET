using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gradingbook
{
    class Program
    {

        static void Main(string[] args)
        {
            string quit = "quit";

            Console.WriteLine("This is your gradebook. Enter student's name or 'quit' to finish");
            string name = Console.ReadLine();
            List<int> grades = new List<int>();

            //BUILD DICTIONARY
            var dictionary = new Dictionary<string, List<int>>();
            dictionary.Add(name, grades);
                                            

            while (name.ToLower() != "quit")
            {
                //ASK FOR STUDENT'S GRADE
                Console.WriteLine("Enter {0}'s grades, separated by a blank space only.", name);
                var grades = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(grades);

            }
                                                    
             else (name.ToLower() == "quit")
            {
                


            }
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
   