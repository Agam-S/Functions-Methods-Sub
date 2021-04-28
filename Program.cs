using System;

namespace Functions_Methods
{
    class Program
    {
     
        public static void welcome()
         {
             System.Console.WriteLine("Welcome Friends");
         }
         public static void HaveANiceDay()
         {
             System.Console.WriteLine("Have a Nice day");
         }        
         public static void Main(string[] args)
         {
         welcome();
         HaveANiceDay();
         }


    class Program2
    {
        public static void welcomeName(string Name)
        {
        System.Console.WriteLine("Welcome Friend " + Name + " !");
         }
        public static void HaveANiceDay()
         {
             System.Console.WriteLine("Have a Nice day");
         } 
        public static void Main(string[] args)
         {
        System.Console.WriteLine("input a name: ");
        string Name = Console.ReadLine();

        welcomeName(Name);
        HaveANiceDay();
         }
    }
    class Program3
    {
    public static int Total(int num1, int num2)
    {
        int total;
        total = num1 + num2;
        return total;
    }
     
    public static void Main(string[] args)
    {
	  Console.WriteLine("Enter a number: ");
      int num1= Convert.ToInt32(Console.ReadLine());

      Console.Write("Enter another number: ");
      int num2= Convert.ToInt32(Console.ReadLine());
      
      Console.WriteLine("The sum of two numbers is :", Total(num1,num2) );
    }
}
}
}
