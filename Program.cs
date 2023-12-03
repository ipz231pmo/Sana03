Console.Write("Enter size of array: ");
int n = int.Parse(Console.ReadLine());
double[] array = new double[n];
int intNums = 0, sumOfPositiveElementsIndex = 0, maxElementIndex = 0;
double sumOfNegativeElements = 0, minElement = 101, maxAbsElement = 0;
Random rnd = new Random();
Console.Write("array = {");
for (int i = 0; i < n; i++){
    array[i] = Math.Round(rnd.NextDouble()*200-100, 2);
    // Chance of generation integer is quite small, so i make every 5-th element int
    if (i % 5 == 0) array[i] = rnd.Next() * 200 - 100;
    Console.Write($"\t{array[i]} ");
    if (array[i] % 1 == 0) intNums++;
    if (array[i] > 0) sumOfPositiveElementsIndex += i;
    if (array[i] < 0) sumOfNegativeElements += array[i];
    if (array[i] > array[maxElementIndex]) maxElementIndex = i;
    if (array[i] < minElement) minElement = array[i];
    if (Math.Abs(array[i]) > Math.Abs(maxAbsElement)) maxAbsElement = array[i];
}
Console.WriteLine("}");
Console.WriteLine($"Array`s negative elements sum: {sumOfNegativeElements}");
Console.WriteLine($"Array`s minimum element: {minElement}");
Console.WriteLine($"Array`s biggest element index: {maxElementIndex}");
Console.WriteLine($"Array`s biggest abs element: {maxAbsElement}");
Console.WriteLine($"Array`s positive elements` indexes sum: {sumOfPositiveElementsIndex}");
Console.WriteLine($"Array`s integer numbers count: {intNums}");