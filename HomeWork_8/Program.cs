//  Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Clear();
Console.Write("Введите число N: ");
int N= int.Parse(Console.ReadLine());
int K;        //количество четных чисел
int number;        
number=1;
K=0;
while(number<=N){
    if (number %2==0){
        K=K+1; 
        number++;
    }
    else {
    number++;
    }   
}
Console.Write($"Koличество четных чисел= {K}");
