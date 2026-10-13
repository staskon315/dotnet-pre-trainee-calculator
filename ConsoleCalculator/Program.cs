class Program
{
    static  List<string> history =new List<string>();
    static void Main()
    {
        Console.WriteLine("Hi, this is a console calculator");
        Console.WriteLine("If you want to terminate the program at any time, enter 'exit'");
        bool exit=false;
        double num1=0,num2=0;
        while (!exit)   
        {
            Console.Write("Select one of the following operations (+, -, *, /, history or exit): ");
            string operation=ReadOperation(ref exit);
            if(exit) break;
            if (operation == "history")
            {
                ShowHistory();
                continue;
            }

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
        if(operation=="history") return operation;
        
        while(operation != "+" && operation != "-" && operation != "*" && operation != "/")
        {
            Console.Write("Unsupported operation. Please use +, -, *, /,(exit) ");
            operation=Console.ReadLine()?? "";
            if(CheckExit( operation,ref exit)) return "";
            if(operation=="history") return operation;
        }
        return operation;
    }
    private static void CalculateAndPrint( string operation, double num1, double num2)
    {
        string? result=null;
        switch (operation)
            {
                case "+":
                    result=$"{num1} {operation} {num2} = {num1+num2}";
                    break;
                case "-":
                    result=$"{num1} {operation} {num2} = {num1-num2}";
                    break;
                case "*":
                    result=$"{num1} {operation} {num2} = {num1*num2}";
                    break;
                case "/":
                    if (num2 == 0)
                    {
                         Console.WriteLine("Division by zero is not allowed");
                         return;
                    }
                    else result=$"{num1} {operation} {num2} = {num1/num2}";
                    break;
            }
        if (result != null)
        {
             Console.WriteLine(result);
            history.Add(result?? "");
        }
    }
    private static bool CheckExit( string str,ref bool exit)
    {
        if(str=="exit"){
            Console.WriteLine("Program termination");
            exit=true;
            return true;
        }
        else return false;
    }
    private static void ShowHistory()
    {
        if(history.Count()==0) Console.WriteLine("Your history is currently empty.");
        foreach(string part in history)
        {
            Console.WriteLine(part);
        }
    }
}