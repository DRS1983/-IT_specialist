// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись 
// исключительно массивами


string[] sourcearray = { "Hello", "2", "World","5", "Free"};
Console.WriteLine('[' + string.Join(", ", sourcearray) + ']');

string[] newarr = new string[sourcearray.GetLength(0)];
for (int i = 0; i < sourcearray.GetLength(0); i++)
{
    newarr [i] = sourcearray[i];
}

Console.WriteLine('[' + string.Join(", ", newarr) + ']');