Console.WriteLine("#######################################");
Console.Write("Ingresa tus calificacinones separadas por comas => ");
string? notas = Console.ReadLine();
List<string> listaCalificaciones = notas.Split(',',' ', StringSplitOptions.RemoveEmptyEntries).ToList();

foreach ( var nota in listaCalificaciones) {
    Console.WriteLine(nota);
}
