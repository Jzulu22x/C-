//Creamos las variables y les damos los valores
string nombre = "Juan Diego";
string apellido = "Zuluaga Ramirez";
string numeroDeDocumento = "1015187957";
int edad = 17;
string clan = "Berners Lee";

//Imprimo los datos solos
Console.WriteLine("Estoy  imprimiendo "+ nombre +" datos");

//Imprimimos los datos concatenados
Console.WriteLine("Hola!, mi nombre es " + nombre);
Console.WriteLine("Mi apellido es " + apellido);
Console.WriteLine("Tengo " + edad + " años");
Console.WriteLine("Mi numero de documento es " + numeroDeDocumento);
Console.WriteLine("Y estoy en el clan " + clan);

Console.WriteLine($"Hola!!, mi nombre es {nombre} {apellido} tengo {edad} años, mi numero de documento es {numeroDeDocumento} y estoy en el clan {clan}");

//Formas de salto de linea
Console.WriteLine($"Hola!!, mi nombre es {nombre} {apellido} \n tengo {edad} años, mi numero de documento es {numeroDeDocumento} y estoy en el clan {clan}");

Console.WriteLine(
    @$"Hola!!, mi nombre es {nombre} {apellido} 
    tengo {edad} años, mi numero de documento es {numeroDeDocumento} y estoy en el clan {clan}"
    );
