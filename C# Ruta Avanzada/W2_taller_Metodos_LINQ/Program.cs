// 1. Filtra los números mayores a 10 en una lista de enteros.
    var numeros = new List<int>(){1,2,3,654,234,543,345,234,234,6,8,76,5,78,9,65,6};
    var numerosMayoresA10 = numeros.Where(n => n > 10).ToList();
    foreach (var item in numerosMayoresA10)
    {
        Console.WriteLine(item);
    }
// 2. Obtén una lista con los cuadrados de cada número en una lista de enteros.
    var cuadrados = numeros.Select(n => n * n).ToList();
    foreach (var item in cuadrados)
    {
        Console.WriteLine(item);
    }
// 3. Ordena alfabéticamente una lista de nombres.
    var nombres = new List<string>{"Juan", "Ana", "Maria", "Pedro", "Sofia"};
    var nombresOrdenados = nombres.OrderBy(n => n).ToList();
    foreach (var item in nombresOrdenados)
    {
        Console.WriteLine(item);
    }
// 4. Ordena una lista de precios de mayor a menor.
    var precios = new List<decimal> {20.5m, 15.75m, 25.25m, 18.0m, 12.75m};
    var preciosOrdenadosDesc = precios.OrderByDescending(p => p).ToList();
    foreach (var item in preciosOrdenadosDesc)
    {
        Console.WriteLine(item);
    } 
// 5. Encuentra el primer número par en una lista de enteros.
    var primerPar = numeros.FirstOrDefault(n => n % 2 == 0);
    Console.WriteLine(primerPar);
// 6. Encuentra el último nombre en una lista de nombres.
// 7. Obtén el primer número negativo en una lista de enteros, o un valor por defecto si no hay
// ninguno.
// 8. Encuentra el último número mayor a 50 en una lista de enteros, o un valor por defecto si
// no hay ninguno.
// 9. Verifica si algún elemento en una lista de booleanos es verdadero.
// 10. Verifica si todos los elementos en una lista de números son mayores a 0.
// 11. Comprueba si una lista de palabras contiene la palabra "LINQ".
// 12. Cuenta cuántos números pares hay en una lista de enteros.
// 13. Calcula la suma de los elementos en una lista de precios.
// 14. Calcula el promedio de una lista de edades.
// 15. Encuentra el número mínimo en una lista de temperaturas.
// 16. Encuentra el número máximo en una lista de alturas.
// 17. Obtén los primeros 5 elementos de una lista de puntuaciones.
// 18. Salta los primeros 3 elementos de una lista de nombres y obtén los siguientes.
// 19. Elimina los elementos duplicados en una lista de números.
// 20. Convierte una lista de palabras en una lista.
// 21. Convierte una lista de números en un array.
// 22. Filtra los números negativos de una lista y ordénalos de menor a mayor.
// 23. Obtén una lista de longitudes de cada palabra en una lista de palabras.
// 24. Ordena una lista de salarios de menor a mayor y obtén los 3 más bajos.
// 25. Obtén los nombres más largos en una lista de nombres.
// 26. Encuentra el primer número mayor a 100 en una lista de precios.
// 27. Encuentra el último día del mes en una lista de fechas.
// 28. Obtén el primer nombre que empieza con 'A' en una lista de nombres o un valor por
// defecto si no hay ninguno.
// 29. Encuentra el último número impar en una lista de enteros o un valor por defecto si no hay
// ninguno.
// 30. Verifica si alguna palabra en una lista de palabras tiene más de 10 caracteres.
// 31. Verifica si todas las edades en una lista son mayores de 18.
// 32. Comprueba si una lista de ciudades contiene la ciudad "Madrid".
// 33. Cuenta cuántos números mayores a 50 hay en una lista de puntuaciones.
// 34. Calcula la suma de los números positivos en una lista de enteros.
// 35. Calcula el promedio de las calificaciones en una lista de calificaciones.
// 36. Encuentra la temperatura mínima en una lista de temperaturas.
// 37. Encuentra la altura máxima en una lista de alturas.
// 38. Obtén los primeros 10 elementos de una lista de productos.
// 39. Salta los primeros 5 elementos de una lista de palabras y obtén los siguientes.
// 40. Elimina los elementos duplicados en una lista de nombres y ordénalos alfabéticamente