//Создали строку для определения того войдет ли программа в цикл или нет
string stopOrRerun = "run";

while (stopOrRerun == "run")
{
    Console.Write("Введите номер операции 1-сложение | 2-вычитание | 3-умножение | 4-деление: ");
    int result;
    while (!int.TryParse(Console.ReadLine(), out result) || (result != 1 && result != 2 && result != 3 && result != 4))
    {
        Console.WriteLine("Введите число от 1 до 4");
    }

    Console.Write("Введите значение переменной a: ");
    double a;
    while (!double.TryParse(Console.ReadLine(), out a))
    {
        Console.WriteLine("Введите число, а не строку");
    }

    Console.Write("Введите значение переменной b: ");
    double b;
    while (!double.TryParse(Console.ReadLine(), out b) || b == 0)
    {
        Console.WriteLine("b не может быть нулём или строкой");
    }

    switch (result)
    {
        case 1:
            Console.WriteLine($"a + b = {a + b}");
            break;
        case 2:
            Console.WriteLine($"a - b = {a - b}");
            break;
        case 3:
            Console.WriteLine($"a * b = {a * b}");
            break;
        case 4:
            Console.WriteLine($"a + b = {a / b}");
            break;
    }

    Console.Write("Введите run для перезапуска или stop для выхода: ");
    stopOrRerun = Console.ReadLine();
}