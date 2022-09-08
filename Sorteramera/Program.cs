int[] tal = new int[] { 1, 3, 2, 5, 4, 9, 2 };

for (int i = 0; i < tal.Length; i++)
{
	for (int j = 0; j < tal.Length; j++)
	{
		if (tal[j] > tal[i])
		{
			//Byt index plats
			int temp = tal[i];
			tal[i] = tal[j];
			tal[j] = temp;
		}
	}
}
foreach (var item in tal)
{
    Console.WriteLine(item);
}