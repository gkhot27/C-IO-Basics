//C#: IO Basics

using System;

class Program{
    public static void Main(){

        // Step1: Taking the input
        string? inputs = Console.ReadLine();
        if (inputs == null){
            Console.WriteLine("Error reading the line");
            return;
        }
        string[] parts = inputs.Split(' ',StringSplitOptions.RemoveEmptyEntries);
        if (parts.Length != 3){
            Console.WriteLine("Invalid input");
            return;
        }
        
        
        char op = parts[0][0]; //breaks it into string to characters,bc parts[0] is a string and parts[0][0] is character it is easier for a switch statements

        int left,right;
        //Basically it takes parts[1] and checks if it's a integer and if it is then it will put it into to the left variable, parts[2] takes it and puts it into right variable if it's a int
        if (!int.TryParse(parts[1], out left) || !int.TryParse(parts[2], out right))
        {
            Console.WriteLine("Error, please use a int");
            return;
        }
        int result;
        switch(op)
        {
            case '+':
                result = left + right;
                Console.WriteLine(result);
                break;
            //add
            case '-':
                result = left - right;
                Console.WriteLine(result);
                break;
            //subtract
            case '*':
                result = left * right;
                Console.WriteLine(result);
                break;
            //multiply
            case '/':
                result = left / right;
                Console.WriteLine(result);
                break;
            //divide
            case '%':
                result = left % right;
                Console.WriteLine(result);
                break;
            //modulo
            default:
                Console.WriteLine("Invalid operator "+ op + ".");
                break;
        }
    }
        

}
