//CONDICIONALES 

Console.Write("Ingrese su edad => ");
int edad = Convert.ToInt32(Console.ReadLine());

//Condicional simple
if (edad >= 18) {
    Console.WriteLine("Eres mayor de edad");
}

//Condicional normal

if (edad >= 18) {
    Console.WriteLine("Eres mayor de edad");
} else {
    Console.WriteLine("Eres menor de edad");
}

//Condicional compuesta

if (edad >= 18) {
    Console.WriteLine("Eres mayor de edad");
} else if (edad >= 12 && edad < 18) {
    Console.WriteLine("Eres adolescente");
} else {
    Console.WriteLine("Eres menor de edad");
}


//Constantes

Console.Write("Ingrese un numero del 1 al 7 por favor => ");
byte numero = Convert.ToByte(Console.ReadLine());

if (numero == 1) {
    Console.WriteLine("Lunes");
}

else if (numero == 2) {
    Console.WriteLine("Martes");
}

else if (numero == 3) {
    Console.WriteLine("Miercoles");
}

else if (numero == 4) {
    Console.WriteLine("Jueves");
}

else if (numero == 5) {
    Console.WriteLine("Viernes");
}

else if (numero == 6) {
    Console.WriteLine("Sabado");
}

else if (numero == 7) {
    Console.WriteLine("Domingo");
}

else {
    Console.WriteLine("No ingresaste un valor valido");
}

switch (numero) {
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
        Console.WriteLine("No ingresaste un valor valido");
        break;
}