//Напишите программу, которая будет принимать на вход два числа и выводить, 
//является ли второе число кратным первому. Если число 1 не кратно числу 2, то 
//программа выводит остаток от деления.
Console.WriteLine("Введите 1-ое число: ");
int a=int.Parse(Console.ReadLine());
Console.WriteLine("Введите 2-ое число: ");
int b=int.Parse(Console.ReadLine());
int остаток=a%b;
if (a%b == 0)
{
 Console.WriteLine("Кратно");
}
else 
{
Console.WriteLine($"Не кратно, остаток {остаток}");    
}