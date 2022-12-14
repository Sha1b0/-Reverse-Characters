namespace xyz
{
    class xyz
    {

        static void Main(string[] args)
        {
            string firstname;
            string lastname;
            string city;
            
            
            
            Console.Write("Enter your First Name:");
            firstname =Console.ReadLine();


            Console.Write("Enter your Last Name:");
            lastname = Console.ReadLine();


            Console.Write("Enter your City:");
            city = Console.ReadLine();


            char[] FirstnameArray = firstname.ToCharArray();
            Array.Reverse(FirstnameArray);

            char[] LastnameArray = lastname.ToCharArray();
            Array.Reverse(LastnameArray);

            char[] CityArray = city.ToCharArray();
            Array.Reverse(CityArray);

            string result = "";


            foreach (char item in FirstnameArray)
            {
                 result += item;
            }

            result += " ";



            foreach (char item in LastnameArray)
            {
                result += item;
            }
            result += " ";

            foreach (char item in CityArray)
            {
                result += item;
            }

            Console.WriteLine("Result:" + result);
            Console.Beep();



















        }















    }
}