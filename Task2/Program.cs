/*Задача 21

Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53*/

int getQuarterFromUser(string message) {
    int result = 0;

    while (true) {
        Console.WriteLine(message);

        if(int.TryParse(Console.ReadLine(), out result)) {
            break;
        }
        else {
            Console.WriteLine("Ввели не число или не корректное число. Повторите ввод!");
        }
    }

    return result;
}

double getDistance(int ax, int ay, int az, int bx, int by, int bz) {
    double result = Math.Sqrt(Math.Pow(ax-bx,2)+Math.Pow(ay-by,2)+Math.Pow(az-bz,2));
    return result;
}
int ax=getQuarterFromUser("Введите aх");
int ay=getQuarterFromUser("Введите ay");
int az=getQuarterFromUser("Введите az");

int bx=getQuarterFromUser("Введите bх");
int by=getQuarterFromUser("Введите by");
int bz=getQuarterFromUser("Введите bz");
double distance =getDistance(ax, ay, az, bx, by, bz);
Console.WriteLine($"Расстояние между точками A({ax},{ay},{ay}) и B({bx},{by},{bz}) равно {distance:f2}");