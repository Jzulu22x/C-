//---------------------------------------------------- Ejercicio 1  -----------------------------------------------------------------//
for (int i = 0; i < 100; i++) {
    Console.WriteLine(i+1);
}

//---------------------------------------------------- Ejercicio 2  -----------------------------------------------------------------//
bool number = true;
Console.Write("Ingrese un numero => ");
int numero = int.Parse(Console.ReadLine());

// Verificacion del numero, para que sea positivo, es decir mayor a 0
while (number) {
    if (numero > 0){
        number = false;
    } else {
        Console.WriteLine("El numero ingresado es negativo, por favor ingresa un numero positivo");
        Console.Write("Ingrese un numero => ");
        numero = int.Parse(Console.ReadLine());
    }
}

for (int inum = 0; inum < numero; inum++) {
    if (inum % 2 == 0 && inum != 0) {
        Console.WriteLine(inum);
    }
}

//---------------------------------------------------- Ejercicio 3  -----------------------------------------------------------------//
bool number3 = true;
Console.Write("Ingrese un numero => ");
int numero1 = int.Parse(Console.ReadLine());

// Verificacion del numero, para que sea positivo, es decir mayor a 0
while (number3) {
    if (numero1 > 0){
        number3 = false;
    } else {
        Console.WriteLine("El numero ingresado es negativo, por favor ingresa un numero positivo");
        Console.Write("Ingrese un numero => ");
        numero1 = int.Parse(Console.ReadLine());
    }
}

for (int imult = 1; imult <= 10; imult++) {
    Console.WriteLine(numero1 + " x " + imult + " = " + (numero1 * imult));
}

//---------------------------------------------------- Ejercicio 4  -----------------------------------------------------------------//
Random rand = new Random();
int numeroAdivinar = rand.Next(100);
Console.WriteLine(numeroAdivinar);

//---------------------------------------------------- Ejercicio 5  -----------------------------------------------------------------//
//---------------------------------------------------- Ejercicio 6  -----------------------------------------------------------------//
//---------------------------------------------------- Ejercicio 7  -----------------------------------------------------------------//
//---------------------------------------------------- Ejercicio 8  -----------------------------------------------------------------//
//---------------------------------------------------- Ejercicio 9  -----------------------------------------------------------------//
//---------------------------------------------------- Ejercicio 10 -----------------------------------------------------------------//