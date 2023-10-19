//stranisa_41_1
int u;
int y;
int x = 0;
int P;
int sum;
Console.WriteLine("Введите натуральное число n");
u = Convert.ToInt32(Console.ReadLine());
P = u;
while (u != 0)
{
    if (u / 10 == 0)
        x = u;
    u /= 10;
}
y = P % 10;
sum = x + y;
Console.WriteLine($"сумма первого и последнего числа равны = {sum}");