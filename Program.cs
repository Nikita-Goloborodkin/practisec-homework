int[] nik = {2, 6, 899, 90, 814};
int find = 90;
int n = nik.Length;
int index = 0;
while(index<n)
{
    if (nik[index] == find){
        Console.WriteLine(index); 
    }
    index++;
}