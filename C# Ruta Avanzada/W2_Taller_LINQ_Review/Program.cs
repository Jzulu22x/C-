using System.Data;

Console.Clear();
//Lista que se va a utilizar
List<int> numbers = new List<int> {1 ,2 ,3 ,4 ,5 ,6 ,7 ,8 ,9 ,10 };

// ● Filtrar y mostrar solo los números pares de la lista numbers.
Console.WriteLine("####################################################################################################################");
var numerosPares = numbers.Where(n => n % 2 == 0).ToList();
Console.WriteLine($"Los Numeros pares de la lista son: {string.Join(" ,", numerosPares)}");
Console.WriteLine("####################################################################################################################");
// ● Usando LINQ, calcular la suma de todos los números impares en la lista numbers.
Console.WriteLine("####################################################################################################################");
var numerosImpares = numbers.Where(n => n % 2 != 0).ToList();
var sumaImpares = numerosImpares.Sum();
Console.WriteLine($"La suma de los numeros impares de la lista es: {sumaImpares}");
Console.WriteLine("####################################################################################################################");
// ● Ordenar de manera descendente los números mayores que 5 en la lista numbers.
Console.WriteLine("####################################################################################################################");
var numMayor5 = numbers.Where(n => n > 5).ToList();
var ordenDescendente = numMayor5.OrderByDescending( n => n);
Console.WriteLine(string.Join(", ", ordenDescendente));
Console.WriteLine("####################################################################################################################");
// ● Contar cuántos números son menores o iguales a 3 en la lista numbers.
Console.WriteLine("####################################################################################################################");
var numMenoIgual3 = numbers.Where(n => n <= 3);
Console.WriteLine($"En la lista hay {numMenoIgual3.Count()} numeros iguales o menores a 3");
Console.WriteLine("####################################################################################################################");
// ● Seleccionar cada número en la lista numbers y multiplicarlo por 2.
Console.WriteLine("####################################################################################################################");
var numbersDuplicado = numbers.Select(n => n * 2);
Console.WriteLine(string.Join(", ",numbersDuplicado));
Console.WriteLine("####################################################################################################################");

Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");

//Lista que se va a utilizar
List<string> names = new List<string> {"Alice", "Bob", "Charlie", "David", "Eve"};

// ● Ordenar los nombres en la lista names alfabéticamente.
Console.WriteLine("####################################################################################################################");
var namesOrder = names.OrderBy(n => n).ToList();
Console.WriteLine(string.Join(", ",namesOrder));
Console.WriteLine("####################################################################################################################");
// ● Seleccionar los nombres en la lista names que empiezan con la letra 'A'.
Console.WriteLine("####################################################################################################################");
var startWhitA = names.Where(n => n.StartsWith("A"));
Console.WriteLine(string.Join(", ", startWhitA));
Console.WriteLine("####################################################################################################################");
// ● Contar cuántos nombres en la lista names tienen más de 5 caracteres.
Console.WriteLine("####################################################################################################################");
var namesMas5Caracteres = names.Where(n => n.Length > 5);
Console.WriteLine(string.Join(", ", namesMas5Caracteres));
Console.WriteLine("####################################################################################################################");
// ● Concatenar todos los nombres de la lista names en una sola cadena separada por
// espacios.
Console.WriteLine("####################################################################################################################");
Console.WriteLine(string.Join(" " , names));
Console.WriteLine("####################################################################################################################");
// ● Encontrar y mostrar el nombre más largo en la lista names.
Console.WriteLine("####################################################################################################################");
var nombreMayor = names.OrderByDescending(n => n.Length).First();
Console.WriteLine(string.Join(" ", nombreMayor));
Console.WriteLine("####################################################################################################################");

Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");

//Lista que se va a utilizar
List<string> words = new List<string> {"apple", "banana", "cherry", "date", "elderberry"};

// ● Verificar si todas las palabras en la lista words tienen más de 3 caracteres.
Console.WriteLine("####################################################################################################################");
var verificacionMas3 = words.Select(n => n.Length >= 3).ToList();
bool cantidad = true;
foreach (var item in verificacionMas3)
{
    if(!item){
        cantidad = false;
    }
}
if(cantidad){
    Console.WriteLine("Todas las palabras tienen mas de 3 letras");
}
else{
    Console.WriteLine("Alguna palabras no tienen mas de 3 letras");
}
Console.WriteLine("####################################################################################################################");

// ● Encontrar y mostrar la primera palabra en la lista words que empieza con la letra 'b'.
Console.WriteLine("####################################################################################################################");
var primeraLetraConB = words.FirstOrDefault(n => n.StartsWith("B",StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine(string.Join(", ",primeraLetraConB));
Console.WriteLine("####################################################################################################################");

// ● Contar cuántas palabras en la lista words contienen la letra 'e'.
Console.WriteLine("####################################################################################################################");
var inicianCone = words.Select(n => n.StartsWith("e",StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine(string.Join(", ", inicianCone.Count()));
Console.WriteLine("####################################################################################################################");

// ● Seleccionar todas las palabras en la lista words y convertirlas a mayúsculas.
Console.WriteLine("####################################################################################################################");
var convertirPrimeraMayus = words.Select(word => char.ToUpper(word[0]) + word.Substring(1));
Console.WriteLine(string.Join(", ", convertirPrimeraMayus));
Console.WriteLine("####################################################################################################################");

// ● Verificar si alguna palabra en la lista words termina con la letra 'y'.
Console.WriteLine("####################################################################################################################");
var terminaWordY = words.Select(n => n.EndsWith("Y", StringComparison.CurrentCultureIgnoreCase)).ToList();
bool terminaY = false;
foreach (var item in terminaWordY)
{
    if (item){
        terminaY = true;
        break;
    }
}

if(!terminaY){
    Console.WriteLine("Ninguna palabra termina en y");
}
else {
    Console.WriteLine("Alguna palabra termina en Y");
}
Console.WriteLine("####################################################################################################################");

Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");

//Listas A Utilizar
List<int> data = new List<int> {2,5,1,6,3,8,4,7,9};
List<int> moreData = new List<int> {10,12,15,11,14,13};

// ● Combinar y ordenar las listas data y moreData de forma ascendente.
Console.WriteLine("####################################################################################################################");
var newList = data.Concat(moreData).OrderBy(n => n);
Console.WriteLine(string.Join(", ", newList));
Console.WriteLine("####################################################################################################################");

// ● Calcular la suma de todos los números pares en la lista data.
Console.WriteLine("####################################################################################################################");
var paresListaSuma = newList.Where(n => n % 2 == 0).Sum();
Console.WriteLine($"La suma de todos los datos pares es {paresListaSuma}");
Console.WriteLine("####################################################################################################################");

// ● Encontrar el número más grande en la lista data.
Console.WriteLine("####################################################################################################################");
var numeroMayor = newList.Max();
Console.WriteLine($"El numero mayor de la lista es {numeroMayor}");
Console.WriteLine("####################################################################################################################");

// ● Unir las listas data y moreData, eliminando los elementos duplicados.
Console.WriteLine("####################################################################################################################");
Console.WriteLine("####################################################################################################################");

// ● Calcular el promedio de la lista moreData y seleccionar los números en data que son
// mayores que ese promedio.
Console.WriteLine("####################################################################################################################");
var promedioMoreData = moreData.Average();
var dataMayorAverge = data.Where( n => n > promedioMoreData);
Console.WriteLine($"Los numeros mayores al Promedio {promedioMoreData} son {string.Join(", ", dataMayorAverge)}");   
Console.WriteLine("####################################################################################################################");

// ● Contar cuántos números en la lista moreData son números primos(te recomiendo crear
// una función independiente que valide si el número es primo o no lo es, luego esa funciona
// pasala al método LINQ adecuado).
Console.WriteLine("####################################################################################################################");
var primoMoreData = moreData.Where(n =>
        {
            if (n <= 1) return false;  // 1 y números negativos no son primos

            // Verificar si n es divisible por algún número además de 1 y n
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;  // n no es primo si tiene divisores adicionales
                }
            }

            return true;  // n es primo si no tiene divisores adicionales
        });

        // Imprimir los números primos
        Console.WriteLine("Números primos en moreData:");
        foreach (var numero in primoMoreData)
        {
            Console.WriteLine(numero);
        }
Console.WriteLine("####################################################################################################################");

