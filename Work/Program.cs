Console.Clear();
//Записали метод вывода массива на консоль.
void PrintArray(string [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] +  " ");
    }
}

string [] array = {"whd","bwfw", "ebfewe", "fbew", "qw", "12"};

//Определил размерность второго массива
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        count = count + 1;
    }
}
string [] mass = new string [count];

//Определил элементы второго массива
int l = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        mass[l] = array[i];
        l++;
    }
}

PrintArray(array);
System.Console.WriteLine();
PrintArray(mass);