using System.Reflection.Metadata;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hi, this is a console calculator");
        Console.WriteLine("If you want to terminate the program at any time, enter 'exit'");
        bool exit=false;
        string? str="";
        while (!exit)   
        {

            Console.Write("Select one of the following operations (+, -, *, /,exit): ");


            string? operation=Console.ReadLine();
            if(operation=="exit"){
                 Console.Write("program termination");
                 exit=true;
                }
            

            while(operation != "+" && operation != "-" && operation != "*" && operation != "/")
            {
                Console.Write("Invalid data entered. Please try again ");
                operation=Console.ReadLine();
                if(operation=="exit"){
                 Console.Write("program termination");
                 exit=true;
                 break;
                }
            }
            if(exit==true) break; 



            Console.Write(" Enter 1 number/(exit): ");
            str=Console.ReadLine();
            if(str=="exit"){
                 Console.WriteLine("program termination");
                 break;
            }
            
            bool transform=double.TryParse(str,out double num1);
            while (!transform)
            {
                Console.Write(" Invalid data entered. Please try again ");
                str=Console.ReadLine();
                if(str=="exit"){
                 Console.WriteLine("program termination");
                 break;
                }
                transform=double.TryParse(str,out  num1);
            }
            if(exit==true) break; 

            Console.Write(" Enter 2 number/(exit): ");
            str=Console.ReadLine();
            if(str=="exit"){
                 Console.WriteLine("program termination");
                 break;
            }
            
             transform=double.TryParse(str,out double num2);
            while (!transform)
            {
                Console.Write(" Invalid data entered. Please try again ");
                str=Console.ReadLine();
                if(str=="exit"){
                 Console.WriteLine("program termination");
                 break;
                }
                transform=double.TryParse(str,out  num2);
            }
            if(exit==true) break; 
            switch (operation)
            {
                case "+":
                        Console.WriteLine($"{num1}{operation}{num2}={num1+num2}");
                        break;
                case "-":
                        Console.WriteLine($"{num1}{operation}{num2}={num1-num2}");
                        break;
                case "*":
                        Console.WriteLine($"{num1}{operation}{num2}={num1*num2}");
                        break;
                case "/":
                        if(num2==0)  Console.WriteLine($"An exception occurred.");
                        else Console.WriteLine($"{num1}{operation}{num2}={num1/num2}");
                        break;
            }
            

        }
        

    
        
    }
}