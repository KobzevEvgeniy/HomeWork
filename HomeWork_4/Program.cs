// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Clear();
Console.Write("Введите первое число: ");
int number1= int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2= int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int number3= int.Parse(Console.ReadLine());
int maxnumber;
maxnumber=number1;
if (number2>maxnumber){
    maxnumber = number2;
    }
if (number3>maxnumber){
    maxnumber = number3;
    }
else {
    maxnumber= maxnumber;
 }
 Console.Write($"Максимальное число равно {maxnumber} ");
