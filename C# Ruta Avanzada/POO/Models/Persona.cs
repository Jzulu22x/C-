using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO.Models;
public class Persona
{
    public int Id { get; set; }
    public string? Nombre { get; set; }
    public string? Genero { get; set; }
    public string? Nacionalidad { get; set; }
    public string? Telefono { get; set; }
    public string? Correo { get; set; }
    public string? FechaNacimiento { get; set; }

    public Persona(string nombre)
    {
        this.Nombre = nombre;
    }

    public void Saludar()
    {
        Console.WriteLine($"Hola, mi nombre es {Nombre}");
    }

    // public int Sumar()
    // {
    //     int num1 = 52;
    //     int num2 = 8;
    //     int suma = num1 + num2;
    //     return suma;
    // }


}