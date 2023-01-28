//напишите программу, которая на вход принимает трехзначное число, и показывает последнее число//
Console.Clear();
Console.Write("Введите число: ");
int number= int.Parse(Console.ReadLine());
if (number<100 || number==999){
Console.WriteLine("Введено не верное число");
return;
}
int otvet =number %10;
   
    Console.WriteLine($"третье число {otvet}");
    Console.WriteLine("------------------------------");
    Console.WriteLine("второй вариант решения задачи");
    string num = Console.ReadLine();
    string otvet2 = Convert.ToString(num[2]);
    Console.WriteLine($"третье число {otvet2}");
