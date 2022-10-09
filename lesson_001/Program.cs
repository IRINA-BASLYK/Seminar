// Задача 1


/*

Console.WriteLine("Please, input your number:");
string numberStr;
numberStr = Console.ReadLine();

int number = int.Parse(numberStr);

Console.WriteLine(number*number);






// Задача 2

Console.WriteLine("Введите первое число");
int a=int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b=int.Parse(Console.ReadLine());
if (b*b==a)
{
   Console.WriteLine("Является квадратом второго числа:"); 
}
else
{
  Console.WriteLine("Первое число не вляется квадратом второго числа:");   
}






// Задача 3

Console.WriteLine("Enter 3 or5"); 
string numberStr;
numberStr = Console.ReadLine();

//int number=int.Parse(numberStr);

if (numberStr=="3")
{
   Console.WriteLine("Среда");  
}
else {
    if (numberStr=="5"){
        Console.WriteLine("Пятница"); 
        }
        else
        {
                Console.WriteLine("Введи 3 или 5");
        }
     }






// Задача 5

Console.WriteLine("Input number:");
string numberStr;
numberStr = Console.ReadLine();
int n = int.Parse(numberStr);
int a = n * (-1);
while (a<=n){
    Console.WriteLine(a);
    a = a + 1;
}






// Задача 5

Console.WriteLine("Введите трехзначное число:");
int a=int.Parse(Console.ReadLine());
Console.WriteLine(a%10);



for (let i = 2; i <= 10; i++) {
  if (i % 2 == 0) {
    alert( i );
  }
}




*/


//Код к задаче: «Вывести четные числа от 2 до 100»

for (int x = 1; x <= n; x++)       
   if (x%2==0)            
Console.WriteLine(x);