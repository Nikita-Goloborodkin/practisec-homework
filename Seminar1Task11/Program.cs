Console.Write("Введите число_1: ");
var number_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число_2: ");
var number_2 = Convert.ToInt32(Console.ReadLine());
if (number_1 == Math.Pow(number_2, 2)){
    Console.WriteLine($"Число {number_1} является квадратом числа {number_2}");
}
else{
    Console.WriteLine($"Число {number_1} не является квадратом числа {number_2}");
}
    