//------------------------------------------------------------- Ejercicio 1 ------------------------------------------------------------------------//
Console.WriteLine("Hola Mundo");

//------------------------------------------------------------- Ejercicio 2 ------------------------------------------------------------------------//
int numero = 12345678;
string texto = "This is a text in C#";

Console.WriteLine(numero);
Console.WriteLine(texto);

//------------------------------------------------------------- Ejercicio 3 ------------------------------------------------------------------------//
string textoMayuscula = texto.ToUpper();
string textoMinuscula = texto.ToLower();

Console.WriteLine(textoMayuscula);
Console.WriteLine(textoMinuscula);

//------------------------------------------------------------- Ejercicio 4 ------------------------------------------------------------------------//
int numero1 = 234;
int numero2 = 567;

int suma = numero1 + numero2;
int resta = numero1 - numero2;
int multiplicacion = numero1 * numero2;
int division = numero1 / numero2;

Console.WriteLine(suma);
Console.WriteLine(resta);
Console.WriteLine(multiplicacion);
Console.WriteLine(division);

//------------------------------------------------------------- Ejercicio 5 ------------------------------------------------------------------------//
int numero3 = 234;
int numero4 = 567;

if (numero3 > numero4){
    Console.WriteLine($"{numero3} es mayor que {numero4}");
}
else if (numero3 < numero4){
    Console.WriteLine($"{numero3} es menor que {numero4}");
}
else if (numero3 == numero4){
    Console.WriteLine($"{numero3} y {numero4} son iguales");
}
else {
    Console.WriteLine($"{numero3} y {numero4} son diferentes");
}

//------------------------------------------------------------- Ejercicio 6 ------------------------------------------------------------------------//
string fraseOriginal = "En esta frase se buscara una palabra y se reemplazara por otra";
string fraseModificada = fraseOriginal.Replace("frase", "aguacate");

Console.WriteLine(@$"la frase original es: {fraseOriginal}
la frase modificada es: {fraseModificada}");

//------------------------------------------------------------- Ejercicio 7 ------------------------------------------------------------------------//
Console.Write("ingresa el nombre: ");
string? nombreUsuario = Console.ReadLine();
Console.Write("Ingrese su edad: ");
string? edadUsuarioTexto = Console.ReadLine();
Console.WriteLine(@$"Hola {nombreUsuario}, tu edad es {edadUsuarioTexto}");

//------------------------------------------------------------- Ejercicio 8 ------------------------------------------------------------------------//
int numero5 = Convert.ToInt32(Console.ReadLine());

if (numero5 > 10){
    Console.WriteLine($"{numero5} es mayor que 10");
}
else if (numero5 < 10){
    Console.WriteLine($"{numero5} es menor que 10");
}
else{
    Console.WriteLine($"{numero5} es igual a 10");
}

//------------------------------------------------------------- Ejercicio 9 ------------------------------------------------------------------------//
double numero6 = 234;
double numero7 = 567;

double sumaDouble = numero6 + numero7;
double restaDouble = numero6 - numero7;
double multiplicacionDouble = numero6 * numero7;
double divisionDouble = numero6 / numero7;

Console.WriteLine(sumaDouble);
Console.WriteLine(restaDouble);
Console.WriteLine(multiplicacionDouble);
Console.WriteLine(divisionDouble);


//------------------------------------------------------------- Ejercicio 10 -----------------------------------------------------------------------//
string palabra1 = "Hola";
string palabra2 = "Mundo";

Console.WriteLine($"{palabra1} {palabra2}");

//------------------------------------------------------------- Ejercicio 11 -----------------------------------------------------------------------//
int numero8 = 1234;
int numero9 = 8273;

double numero8Double = Convert.ToDouble(numero8); 
double numero9Double = Convert.ToDouble(numero9); 

Console.WriteLine(numero8Double);
Console.WriteLine(numero9Double);

//------------------------------------------------------------- Ejercicio 12 -----------------------------------------------------------------------//
Console.Write("Ingrese un numero: ");
int numeroUsuario = Convert.ToInt32(Console.ReadLine());

if (numeroUsuario == 0) {
    Console.WriteLine($"{numeroUsuario} es igual a 0");
}
else if (numeroUsuario > 0){
    Console.WriteLine($"{numeroUsuario} es mayor que 0");
}
else{
    Console.WriteLine($"{numeroUsuario} es menor que 0");
} 

//------------------------------------------------------------- Ejercicio 13 -----------------------------------------------------------------------//
for (int i = 0; i <= 10; i++) {
    Console.WriteLine(i);
}

//------------------------------------------------------------- Ejercicio 14 -----------------------------------------------------------------------//
string textoTrimCapital = "hola, a este texto se le quitaran los espacios del principio y del final, y la primera letra se pondra en mayuscula";
string textoSinEspacios = textoTrimCapital.Trim();


//------------------------------------------------------------- Ejercicio 15 -----------------------------------------------------------------------//
Console.Write("Ingrese el numero del cual quieres saber su tabla: ");
int numeroTabla = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= 10; i++){
    Console.WriteLine($"{numeroTabla} X {i} = {numeroTabla * i}");
}

//------------------------------------------------------------- Ejercicio 16 -----------------------------------------------------------------------//

//------------------------------------------------------------- Ejercicio 17 -----------------------------------------------------------------------//
