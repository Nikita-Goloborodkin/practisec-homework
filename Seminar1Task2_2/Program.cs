// Console.WriteLine("Введите число: "); string? line = Console.ReadLine();
// if (line != null)
// {
//     int day = int.Parse(line); string[] dayNik = new string[7];
//     dayNik[0] = "Понедельник"; dayNik[1] = "Вторник"; dayNik[2] = "Среда";
//     dayNik[3] = "Четверг"; dayNik[4] = "Пятница"; dayNik[5] = "Суббота";
//     dayNik[6] = "Воскресенье";
//     Console.WriteLine(dayNik[day-1]);
// }   
Console.WriteLine("Введите число: "); string? line = Console.ReadLine();
if (int.Parse(line) >=0 && int.Parse(line)<7){
    switch (line)
    {
        case "0":
            Console.WriteLine("пн ");
            break;
        case "1":
            Console.WriteLine("Вт ");
            break;
        default:
        Console.WriteLine("Упс...");
        break;
    }


}