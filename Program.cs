// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись 
// исключительно массивами


string[] sourcearray = {"Good day", "5", "World", "a", "Free"};

Console.WriteLine('[' + string.Join(",", sourcearray) + ']');

string s = "";

int n = 0;

for (int i = 0; i < sourcearray.GetLength(0); i++)
{
    s = sourcearray[i];
    if (s.Length < 4 & s.Length > 0)
    n++;
}
Console.WriteLine(n);



string[] newarr = new string[n];

for (int i = 0; i < n; i++)
{

    s = sourcearray[i];
    if (s.Length < 4 & s.Length != 0)
    {
    newarr [i] = sourcearray[i];
    }
    
}

Console.WriteLine('[' + string.Join(",", newarr) + ']');