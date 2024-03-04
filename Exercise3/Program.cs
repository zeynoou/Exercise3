namespace Exercise3
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age :");
            string age = Console.ReadLine();
            var result1 = Convert.ToInt32(age);
            var result2 = get_age(result1);
            Console.WriteLine("Your age in day is:" +  result2);
        }

        public static int get_age(int a)
        {
            int age;
            age = a * 365;
            return age;
        }
    }
}
