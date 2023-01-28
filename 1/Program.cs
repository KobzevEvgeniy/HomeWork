//напишите программу, которая на вход принимает два числа, сравнивает явлется ли первое квадратом второго//
//(число умножемое на себя//
Console.Clear();
Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
if(number1*number1==number2){
Console.WriteLine("Да");
}
else{
Console.WriteLine("Нет");    
}
