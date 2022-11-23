namespace Calculator
{
    class FirstProgram
    {
        static void Main(String[] args)
        {
            Double num1, num2, Result;
            Console.Write("Enter the first Number:");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the second Number:");
            num2 = Convert.ToDouble(Console.ReadLine());

            // Here I am using do-while loop to make choice again
            do
            {
                Console.Write("\nYour options are :\n");
                Console.Write("1-Addition.\n2-Substraction.\n3-Multiplication.\n4-Division.\n5-Exit.\n");
                Console.Write("\n Enter your choice :");
                Result = Convert.ToDouble(Console.ReadLine());

                switch (Result)
                {
                    case 1:
                        Console.WriteLine("Addition is:");
                        Console.Write(num1 + num2);
                        break;

                    case 2:
                        Console.WriteLine("Substraction is:");
                        Console.Write(num1 - num2);
                        break;

                    case 3:
                        Console.WriteLine("Multiplication is:");
                        Console.Write(num1 * num2);
                        break;

                    case 4:
                        if (num2 == 0)
                        {
                            Console.Write(" Make Correct choice......Not Divided by zero.\n");
                        }
                        else
                        {
                            Console.WriteLine("Division is:");
                            Console.Write(num1 / num2);
                        }
                        break;


                    case 5:
                        break; // Exit option..

                    default:
                        Console.Write("Enter correct option:\n"); 
                        break;
                }

            }

            while (Result != 0);
        }
    }
}

    
