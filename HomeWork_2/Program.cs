// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();
Console.Write("Введите первое число: ");
int number1= int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2= int.Parse(Console.ReadLine());
if (number1>number2){
    Console.Write($"Большее число: {number1}; ");
    Console.Write($"Наименьшее число: {number2}");
    return;
}
else {
 Console.Write($"Большее число: {number2}; ");
 Console.Write($"Наименьшее число: {number1}");
}