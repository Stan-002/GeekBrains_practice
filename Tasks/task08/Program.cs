System.Console.WriteLine("Enter number: ");
int number = Convert.ToInt32(Console.ReadLine());

for(int i = 2; i <= number; i = i + 2)
{
    System.Console.Write(i + "\t");
}