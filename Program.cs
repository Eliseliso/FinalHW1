string[] array1 = new string[5] {"git", "kitty", "elis", "11", ":)"};
string[] array2 = new string[array1.Length];
void FinalArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void GetArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
FinalArray(array1, array2);
GetArray(array2);