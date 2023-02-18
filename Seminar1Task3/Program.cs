string? inputline = Console.ReadLine();
if(inputline!=null)
{
    int inputNumber = int.Parse(inputline);
    int StartNumber = inputNumber*(-1);
    string OutLine = string.Empty;
    while(StartNumber<=inputNumber)
    {
        OutLine = OutLine + StartNumber + " ";
        StartNumber++;


    }
    Console.WriteLine(OutLine);
}