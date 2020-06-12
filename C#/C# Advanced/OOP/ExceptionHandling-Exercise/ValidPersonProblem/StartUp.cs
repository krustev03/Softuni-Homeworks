using System;

namespace ValidPersonProblem
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Person Pesho = new Person("Pesho", "Peshev", 24);

            try
            {
                Person noName = new Person(string.Empty, "Goshev", 24);
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine("Exception thrown: {0}", ex.Message);
            }
            catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Exception thrown: {0}", ex.Message);
            }
            
            //Person noLastName = new Person("Ivan", null, 32);

            try
            {
                Person negativeAge = new Person("Gogo", "Sotirov", -3);
            }
            catch(ArgumentNullException ex)
            {
                Console.WriteLine("Exception thrown: {0}", ex.Message);
            }
            catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Exception thrown: {0}", ex.Message);
            }

            //Person tooOld = new Person("Han", "Asparuh", 1369);
        }
    }
}
