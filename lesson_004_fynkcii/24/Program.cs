/* Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7->28
4->10
8->36 */

void GetSumNums(int number){
    int sum=0;
    for (int i = 1; i <= number; i++)
    {
        sum+=i;
    }
    Console.WriteLine(sum);
}
Console.WriteLine("Введите число:");
int a =int.Parse(Console.ReadLine());

GetSumNums(a);
