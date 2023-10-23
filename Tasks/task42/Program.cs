/* 

42. Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3 -> 11
2 -> 10

binary - двоичное
decimal - десятичное



 */

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int ToBinary( int number)
{
    int result= 0;
    int ten = 1;
    while(number>0){
        result=number%2*ten+result;
        number=number/2;
        ten=ten*10;
    }
return result;
}
int Number = ToBinary(number);
Console.Write(Number);

/* 

Console.Clear();
50%
System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

void Number(int binNumber)
{
    int bin = 0;
    for (int i = binNumber; i > 0; i = i / 2)
    {
        if (i == 1)
        {
            bin = 1;
        }
        if (i % 2 == 0)
        {
            bin = 0;
        }
        else
        {
            bin = 1;
        }
        System.Console.Write(bin);
    }
}
Number(number);


 */

 /* 
 100%
 Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

int ToBinary( int number)
{
    int result= 0;
    int ten = 1;
    while(number>0){
        result=number%2*ten+result;
        number=number/2;
        ten=ten*10;
    }
return result;
}
int Number = ToBinary(number);
Console.Write(Number);
  */

  /* 
  90%
  string Conv(int number)
{
    string result = "";
    int tmp = 0;
    for (int i = number; i > 0; i/=2)
    {
        tmp = i % 2;
        result = tmp + result;
    }
    return result;
}

int uNum = UserInOut("Введите число: ");
System.Console.WriteLine(Conv(uNum));
   */