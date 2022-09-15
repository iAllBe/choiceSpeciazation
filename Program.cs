using static System.Console;

Clear();

string[] array = new string[] { "Hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science" };

string[] shortArray = getShortArray(array);

printStringArray(shortArray);

string[] getShortArray(string[] array)
{
    string[] shortArray = new string[array.Length];

    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            shortArray[count] = array[i];
            count++;
        }
    }

    Array.Resize(ref shortArray, count);

    return shortArray;
}

void printStringArray(string[] array)
{
    Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1)
        {
            Write($"{array[i]}");
        }
        else
        {
            Write($"{array[i]}, ");
        }
    }

    Write("]");
}