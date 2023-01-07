// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритмами.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


string[] array = new string[] { "1", "12", "123", "1234", "1" };

void PrintArray(string[] array)
{

	for (int i = 0; i < array.Length; i++)
	{
		Console.Write($"{array[i]} ");
	}
	Console.WriteLine();
}

void Diffarray(string[] array)
{
		for (int i = 0; i < array.Length; i++)
	{
		string element = array[i];

		if (element.Length <= 3)
		{
			array[i] = element;
		}
		else array[i] = string.Empty;
	}
}

PrintArray(array);
Diffarray(array);
PrintArray(array);