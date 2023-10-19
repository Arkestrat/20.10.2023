//stranisa36_1b
Console.WriteLine("Введите значение eps=");
double eps = double.Parse(Console.ReadLine());
double summa = 0;
int d = 1;
double a;
do
{
    a = 1.0 / (Math.Pow(2.0, d)) + 1.0 / (Math.Pow(3.0, d));
    summa += a;
    d++;
}
while (Math.Abs(a) >= eps);
Console.WriteLine($"Сумма последовательности summa={summa}");