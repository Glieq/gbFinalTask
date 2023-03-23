string[] array = { "hello", "2", "world", ":-)" };
string[] array2 = { "Russia", "Kazan", "Denmark" };

string[] clearArray(string[] mas)
{
    int count = 0;
    int countForArr = 0;
    int countI = 0;
    while (count < mas.Length)
    {
        if (mas[count].Length < 4)
        {
            countForArr++;
        }
        count++;
    }
    count = 0;
    string[] newArr = new string[countForArr];
    while (count < mas.Length)
    {
        if (mas[count].Length < 4)
        {
            newArr[countI] = mas[count];
            countI++;
        }
        count++;
    }
    Console.WriteLine("[{0}]", string.Join(", ", newArr));
    return newArr;
}


clearArray(array);
clearArray(array2);

