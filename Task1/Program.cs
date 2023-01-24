/*Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да*/


int getNumberFromUser(string message)
{
    int resultNumber = 0;

    while(true)
    {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out resultNumber) && (resultNumber <= 99999) && (resultNumber>=10000)) {
            break;
        }
        else {
            Console.WriteLine("Ввели не число или не корректное число. Повторите ввод!");
        }
    }

    return resultNumber;
}
int number=getNumberFromUser("Введите число пятизначное число:");
//   N1  N2  N3  N4  N5
//    1   2   3   2   9  - number

int N1 = number/10000;
int N2 = (number/1000)%10 ;

int N4 = (number/10)%10;
int N5 = number%10;

if (N1==N5 && N2==N4) {
    Console.WriteLine($"Число {number} является палиндромом");
}
else {
    Console.WriteLine($"Число {number}  не является палиндромом");
}