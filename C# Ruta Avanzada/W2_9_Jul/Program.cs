Console.WriteLine("############################################################");

var listaNumerosDesorden = new List<int> () {1,5,7,4,6,9,2,8,3,10};

listaNumerosDesorden.Reverse();
// Console.WriteLine(string.Join(", ",listaNumerosDesorden));
foreach (var item in listaNumerosDesorden)
{
    Console.WriteLine(item);
}

Console.WriteLine("############################################################");

var maxNumber = listaNumerosDesorden.Max(n => n);
Console.WriteLine(maxNumber);

Console.WriteLine("############################################################");

var skipped = listaNumerosDesorden.Skip(2);
foreach (var item in skipped)
{
    Console.WriteLine(item);
}

Console.WriteLine("############################################################");

var average = listaNumerosDesorden.Average();
Console.WriteLine(average);

Console.WriteLine("############################################################");

var take = listaNumerosDesorden.Take(4);
Console.WriteLine(string.Join(", ",take));

Console.WriteLine("############################################################");
