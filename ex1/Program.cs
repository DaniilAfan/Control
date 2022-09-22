string[] array1 = new string[4] {"Yes", "No", "123", "1234"};
string[] array2 = new string[array1.Length];
void SimvolCheckout(string[] array1, string[] array2)
{
    int change = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[change] = array1[i];
        change++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SimvolCheckout(array1, array2);
PrintArray(array2);

