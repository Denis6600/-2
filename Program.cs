Console.WriteLine("Первое число: ");
int numOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Второе число: ");
int numTwo = Convert.ToInt32(Console.ReadLine());

if (numOne > numTwo)
{
    Console.WriteLine("Max = " + numOne + " min = " + numTwo);
}
else
{
    Console.WriteLine("Max " + numTwo + " min " + numOne);
}