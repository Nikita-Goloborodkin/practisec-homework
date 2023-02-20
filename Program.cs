void FillNumber(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while(index<length){
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}
void PrintNumber(int[] call)
{
    int count = call.Length;
    int position = 0;
    while(position<count){
        Console.WriteLine(call[position]);
        position++;
    }
}
int Indexfind (int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while(index<count)
    {
        if(collection[index] == find)
        {
            position = index;
        }
        index++;
    }
    return  position;
}
int[] some = new int[10];
FillNumber(some);
some[4] = 4;
some[5] = 4;
PrintNumber(some);


Console.WriteLine();
int rez = Indexfind(some, 434);
Console.WriteLine(rez);