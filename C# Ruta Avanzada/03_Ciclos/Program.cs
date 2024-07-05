// Cilclo for
for(int i = 0; i < 6; i++){
    Console.WriteLine("Hello, World!");
}

//ciclo foreach

int[] numeros = {1, 2, 3, 4, 5};

foreach(int numero in numeros){
    Console.WriteLine(numero);
}


bool terminar = true;

while(terminar){
    Console.WriteLine("Hello, World!");
    Console.Write("Quieres Repetir la interaccion => ");
    string? respuesta = Console.ReadLine();
    if (respuesta?.ToLower() == "no") {
        terminar = false;
    }
}