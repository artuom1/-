int a = 1;
 int i = 1;
bool not = true;

Console.WriteLine("Введите число:");
 a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Чётные числа от 1 до " + a);
while (i <= a)
 {
    if (i % 2 != 1)
        {
            Console.Write(i + ", ");
             not = false;
}
i++;
}

if (not)
 {
    Console.WriteLine("Нет чётных чисел!");
 }