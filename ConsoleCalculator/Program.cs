class Program
{
    static void Main()
    {
        Console.WriteLine("Hi, this is a console calculator");
        Console.WriteLine("If you want to terminate the program at any time, enter 'exit'");
        bool exit=false;
        double num1=0,num2=0;
        while (!exit)   
        {
            Console.Write("Select one of the following operations (+, -, *, / or exit): ");
            string operation=ReadOperation(ref exit);
            if(exit) break;

            Console.Write(" Enter 1 number/(exit): ");
            ReadNumber(ref exit,ref num1);
            if(exit) break;

            Console.Write(" Enter 2 number/(exit): ");
            ReadNumber(ref exit,ref num2);  
            if(exit) break;
            
            CalculateAndPrint( operation, num1, num2);
        }
    }


    private static void ReadNumber(ref bool exit, ref double num)
    {
        string str=Console.ReadLine() ?? "";
        if(CheckExit( str,ref exit)) return;

        bool transform=double.TryParse(str,out num);
        while (!transform)
        {
            Console.Write("Invalid data entered. Please try again. ");
            str=Console.ReadLine() ?? "";
            if(CheckExit( str,ref exit)) break;
            transform=double.TryParse(str,out  num);
        }      
    }
    private static string ReadOperation(ref bool exit)
    {
        string? operation=Console.ReadLine()?? "";
        if(CheckExit( operation,ref exit)) return "";
        
        while(operation != "+" && operation != "-" && operation != "*" && operation != "/")
        {
            Console.Write("Unsupported operation. Please use +, -, *, /,(exit) ");
            operation=Console.ReadLine()?? "";
            if(CheckExit( operation,ref exit)) return "";
        }
        return operation;
    }
    private static void CalculateAndPrint( string operation, double num1, double num2)
    {
        switch (operation)
            {
                case "+":
                    Console.WriteLine($"{num1} {operation} {num2} = {num1+num2}");
                    break;
                case "-":
                    Console.WriteLine($"{num1} {operation} {num2} = {num1-num2}");
                    break;
                case "*":
                    Console.WriteLine($"{num1} {operation} {num2} = {num1*num2}");
                    break;
                case "/":
                    if(num2==0)  Console.WriteLine("Division by zero is not allowed");
                    else Console.WriteLine($"{num1} {operation} {num2} = {num1/num2}");
                    break;
            }
    }
    private static bool CheckExit( string str,ref bool exit)
    {
        if(str=="exit"){
            Console.WriteLine("program termination");
            exit=true;
            return true;
        }
        else return false;
    }
}