/* Напишите программу, которая принимает на вход число (N) и выдаёт произведение чисел от 1 до N.
4->24
5->120*/

void GetSumNums(int number){
    int sum=1;
    for (int i = 1; i <= number; i++)
    {
        sum*=i;
    }
    Console.WriteLine(sum);
}
Console.WriteLine("Введите число:");
int a =int.Parse(Console.ReadLine());

GetSumNums(a);
