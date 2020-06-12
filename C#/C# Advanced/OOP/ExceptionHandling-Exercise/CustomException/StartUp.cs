using System;

namespace CustomException
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            try
            {
                Student student = new Student("Gin4o", "gin40@abv.bg");
            }
            catch(InvalidPersonNameException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
