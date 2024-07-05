//--------------------------------------------------------------- Ejercicio 1  --------------------------------------------------------------------//
Console.Write("Ingrese un numero => ");
byte numeroParImpar = Convert.ToByte(Console.ReadLine());
if (numeroParImpar % 2 == 0) {
    Console.WriteLine("El numero es par");
} else {
    Console.WriteLine("El numero es impar");
}

//--------------------------------------------------------------- Ejercicio 2  --------------------------------------------------------------------//
Console.Write("Ingrese su nombre => ");
string? nombre = Console.ReadLine();
if(string.IsNullOrWhiteSpace(nombre)) {
    Console.WriteLine("error, no se a detectado ningun nombre");
} else {
    Console.WriteLine($"Hola {nombre}!!, siempre es un placer tenerte por aca");
}

//--------------------------------------------------------------- Ejercicio 3  --------------------------------------------------------------------//
Console.Write("Ingrese su edad => ");
byte edad = Convert.ToByte(Console.ReadLine());
if (edad >= 18) {
    Console.WriteLine("Eres mayor de edad");
} else {
    Console.WriteLine("Eres menor de edad");
}

//--------------------------------------------------------------- Ejercicio 4  --------------------------------------------------------------------//
Console.Write("Ingrese un numero entre 1 y 7 => ");
byte diaSemana = Convert. ToByte(Console.ReadLine());
switch (diaSemana) {
    case 1:
        Console.WriteLine("Lunes");
        break;
    case 2:
        Console.WriteLine("Martes");
        break;
    case 3:
        Console.WriteLine("Miercoles");
        break;
    case 4:
        Console.WriteLine("Jueves");
        break;
    case 5:
        Console.WriteLine("Viernes");
        break;
    case 6:
        Console.WriteLine("Sabado");
        break;
    case 7:
        Console.WriteLine("Domingo");
        break;
    default:
        Console.WriteLine("Error, ingrese un numero entre 1 y 7");
        break;
}

//--------------------------------------------------------------- Ejercicio 5  --------------------------------------------------------------------//
Console.Write("Ingrese su pais => ");
string? pais = Console.ReadLine().ToLower();
if (string.IsNullOrWhiteSpace(pais)){
    Console.WriteLine("Error, No se detecto ningun dato");
}
else{
    Console.WriteLine((pais == "colombia")? "Eres nativo":"Eres Extranjero");
}

//--------------------------------------------------------------- Ejercicio 6  --------------------------------------------------------------------//
Console.Write("Ingrese el primer numero");
byte numero1 = Convert.ToByte(Console.ReadLine());
Console.Write("Ingrese el segundo numero");
byte numero2 = Convert.ToByte(Console.ReadLine());
Console.Write("Ingrese el tercer numero");
byte numero3 = Convert.ToByte(Console.ReadLine());
if (numero1 > numero2 && numero1 < numero3) {
    Console.WriteLine($"{numero1} es mayor que {numero2} y menor que {numero3}");
} else if ( numero2 > numero1 && numero2 > numero3) {
    Console.WriteLine($"{numero2} es mayor que {numero1} y menor que {numero3}");
} else if (numero3 > numero2 && numero3 > numero1) {
    Console.WriteLine($"{numero3} es mayor que {numero1} y menor que {numero2}");
} else {
    Console.WriteLine("Hay numeros iguales");
}

//--------------------------------------------------------------- Ejercicio 7  --------------------------------------------------------------------//
Console.Write("Ingrese una contraseña => ");
string? contraseña = Console.ReadLine();
Console.WriteLine( string.IsNullOrWhiteSpace(contraseña)? "Contaseña no puede estar en blanco"  : "Contaseña aceptada" );

//--------------------------------------------------------------- Ejercicio 8  --------------------------------------------------------------------//
Console.Write("Ingrese un numero del 1 al 12 => ");
byte numeroMes = Convert.ToByte(Console.ReadLine());
switch (numeroMes) {
    case 1:
        Console.WriteLine("Enero");
        break;
    case 2:
        Console.WriteLine("Febrero");
        break;
    case 3:
        Console.WriteLine("Marzo");
        break;
    case 4:
        Console.WriteLine("Abril");
        break;
    case 5:
        Console.WriteLine("Mayo");
        break;
    case 6:
        Console.WriteLine("Junio");
        break;
    case 7:
        Console.WriteLine("Julio");
        break;
    case 8:
        Console.WriteLine("Agosto");
        break;
    case 9:
        Console.WriteLine("Septiembre");
        break;
    case 10:
        Console.WriteLine("Octubre");
        break;
    case 11:
        Console.WriteLine("Noviembre");
        break;
    case 12:
        Console.WriteLine("Diciembre");
        break;
    default:
        Console.WriteLine("Error, ingrese un numero del 1 al 12");
        break;
}

//--------------------------------------------------------------- Ejercicio 9  --------------------------------------------------------------------//
Console.Write("Ingrese la calasificacion numerica de la calasificacion (Desde 0 hasta 5) => ");
float califiacionNumerica = float.Parse(Console.ReadLine());
if (califiacionNumerica >= 0 && califiacionNumerica < 1) {
    Console.WriteLine("F");
} else if (califiacionNumerica >= 1 && califiacionNumerica < 2) {
    Console.WriteLine("D");
} else if (califiacionNumerica >= 2 && califiacionNumerica < 3) {
    Console.WriteLine("C");
} else if (califiacionNumerica >= 3 && califiacionNumerica < 4) {
    Console.WriteLine("B");
} else if (califiacionNumerica >= 4 && califiacionNumerica < 5) {
    Console.WriteLine("A");
} else {
    Console.WriteLine("Error, ingrese un numero entre 0 y 5");
}

//--------------------------------------------------------------- Ejercicio 10 --------------------------------------------------------------------//
Console.Write("Ingrese una letra => ");
string letra = Console.ReadLine().ToLower();
switch (letra) {
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine($"{letra} es una vocal");
        break;
    default:
        Console.WriteLine($"{letra} es una consonante");
        break;
}

//--------------------------------------------------------------- Ejercicio 11 --------------------------------------------------------------------//
Console.Write("Ingrese el primer numero => ");
byte numero1_1 = Convert.ToByte(Console.ReadLine());
Console.Write("Ingrese el segundo numero => ");
byte numero2_1 = Convert.ToByte(Console.ReadLine());
if (numero1_1 != numero2_1) {
    Console.WriteLine("Los numeros son diferentes");
} else {
    Console.WriteLine("Los numeros son iguales");
}

//--------------------------------------------------------------- Ejercicio 12 --------------------------------------------------------------------//
Console.Write("Ingrese una direccion => ");
string? direccion = Console.ReadLine();
Console.WriteLine(string.IsNullOrWhiteSpace(direccion)? "Direccion Invalida":"Direccion Valida");

//--------------------------------------------------------------- Ejercicio 13 --------------------------------------------------------------------//
Console.Write("Ingresa un numero");
float numeroX = float.Parse(Console.ReadLine());

if (numeroX == 0){
    Console.WriteLine("El numero es cero");
} else if (numeroX > 0){
    Console.WriteLine("El numero es positivo");
} else if (numeroX < 0){
    Console.WriteLine("El numero es negativo");
} else {
    Console.WriteLine("Ingrese un numero valido");
}

//--------------------------------------------------------------- Ejercicio 14 --------------------------------------------------------------------//
Console.Write("Ingrese una letra => ");
string letra1_1 = Console.ReadLine().ToLower();
if (letra1_1 ==  "a" || letra1_1 == "e" || letra1_1 == "i" || letra1_1 == "o" || letra1_1 == "u") {
    Console.WriteLine($"la letra {letra1_1} es una vocal");
} else {
    Console.WriteLine($"la letra {letra1_1} es una consonante");
}

//--------------------------------------------------------------- Ejercicio 15 --------------------------------------------------------------------//
Console.Write("Ingresa la temperatura en grados celsius => ");
int celsius = Convert.ToInt32(Console.ReadLine());

if (celsius > 10) {
    Console.WriteLine("Esta haciendo frio");
} else if (celsius >= 10 && celsius < 30) {
    Console.WriteLine("Esta haciendo clima templado");
} else {
    Console.WriteLine("Esta haciendo calor");
} 

//--------------------------------------------------------------- Ejercicio 16 --------------------------------------------------------------------//
Console.WriteLine("Ingrese un año => ");
int anio = int.Parse(Console.ReadLine());
if (anio % 4 == 0 && ( anio % 100 != 0 || anio % 400 == 0)){
    Console.WriteLine("El año es bisiesto");
} else {
    Console.WriteLine("El año no es bisiesto");
}

//--------------------------------------------------------------- Ejercicio 17 --------------------------------------------------------------------//
//--------------------------------------------------------------- Ejercicio 18 --------------------------------------------------------------------//