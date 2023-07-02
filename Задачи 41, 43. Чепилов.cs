Console.Clear();
// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// НАЧАЛО КОДА ЗАДАЧИ 41

/*
int [] ZapolnjaemMassiv(int dlina)
{
    int [] array = new int[dlina];
    for (int i = 0; i < dlina; i++)
        array[i] = Convert.ToInt32(Console.ReadLine());
    return array;
}

int KolichestvoChiselBolsheO(int [] array, int m)
{
    int count = 0;
    for (int i = 0; i < m; i++) if (array[i]>0) count++;
    return count;
}

Console.Write("сколько чисел вы хотите ввести? -> ");
int kol = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("вводите: ");

int [] array = ZapolnjaemMassiv(kol);
//PechatMassiva(array);

int sumChisBolO = KolichestvoChiselBolsheO(array, kol);
Console.Write($"больше нуля из них -> {sumChisBolO}");
*/

// КОНЕЦ КОДА ЗАДАЧИ 41

//------------------------------------------------------------------------------------
//------------------------------------------------------------------------------------

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// НАЧАЛО КОДА ЗАДАЧИ 43


Console.WriteLine("значит, имеем 2 уравнения прямых:");
Console.WriteLine("y = k1 * x + b1");
Console.WriteLine("y = k2 * x + b2");

Console.WriteLine("ну шо, погнали искать их пересечение:");

Console.Write("введите b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("введите k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("введите b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());

Console.Write("введите k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

Console.WriteLine($"точкой пересечения y = {k1}x + {b1} и y = {k2}x + {b2} является координата ({x}; {y}).");

// КОНЕЦ КОДА ЗАДАЧИ 43