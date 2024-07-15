using System;
using System.Collections.Generic;
using System.Diagnostics; // Necesario para usar List<T>

//Creamos La clase venta
public class Venta
{
    public int ID { get; set; }
    public DateTime FechaVenta { get; set; }
    public double ValorProducto { get; set; }
    public int CantidadDeProductos { get; set; }
    public string Vendedor { get; set; }
    public string Comprador { get; set; }
    public int TiempoGarantia { get; set; } // Este valor va en meses

    public Venta(int id, DateTime fechaVenta, double valorProducto, int cantidadDeProductos, string vendedor, string comprador, int tiempoGarantia)
    {
        ID = id;
        FechaVenta = fechaVenta;
        ValorProducto = valorProducto;
        CantidadDeProductos = cantidadDeProductos;
        Vendedor = vendedor;
        Comprador = comprador;
        TiempoGarantia = tiempoGarantia;
    }

    public double CalcularTotalVenta()
    {
        return ValorProducto * CantidadDeProductos;
    }

    public void MostrarDetallesVenta()
    {
        Console.WriteLine($"Fecha de Venta: {FechaVenta}");
        Console.WriteLine($"Vendedor: {Vendedor}");
        Console.WriteLine($"Comprador: {Comprador}");
        Console.WriteLine($"Cantidad de Productos: {CantidadDeProductos}");
        Console.WriteLine($"Valor Unitario: {ValorProducto}");
        Console.WriteLine($"Total de la Venta: {CalcularTotalVenta()}");
        Console.WriteLine($"Tiempo de Garantía: {TiempoGarantia} meses");
    }
}

class Program
{
    static void Main()
    {
        //Creamos la lista
        List<Venta> listaVentas = new List<Venta>();

        // Agregar ventas quemadas
        listaVentas.Add(new Venta(1, DateTime.Now, 25.50, 3, "Juan", "María", 30));
        listaVentas.Add(new Venta(2, DateTime.Now.AddDays(-5), 35.75, 2, "Ana", "Pedro", 24));
        listaVentas.Add(new Venta(3, DateTime.Now.AddDays(-10), 15.25, 5, "Luis", "Sofía", 12));


        //Creo el ciclo para que se repita el menu
        bool runProgram = true;
        int id = 3; //La inicializamos en 3 ya que agregamos 3 productos antes
        while (runProgram)
        {
            Console.Clear();
            //Creamos la intrefaz
            Console.WriteLine(@"
Por Favor Elija La opcion:
1. Agregar Venta
2. Ver Valor Total de Venta Especifica
            ");
        Console.Write("Ingresa la opcion => ");
        string? eleccion = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(eleccion)){
            Console.WriteLine("\nError, valor invalido");
            Console.Write("Presione Cualquier tecla para continuar => ");
            Console.ReadKey();
            break;
        }
        Switch

        }



        // int Id = 0;
        // // Crear una instancia de la clase Venta
        // Venta venta1 = new Venta(Id,DateTime.Now, 25.50, 3, "Juan", "María", 30);

        // // Ejemplo de uso de los métodos de la clase Venta
        // venta1.MostrarDetallesVenta();

        // // Ejemplo de acceso a propiedades individuales
        // Console.WriteLine($"\nEl vendedor es: {venta1.Vendedor}");

        // // Ejemplo de llamada a método que devuelve un valor
        // double totalVenta = venta1.CalcularTotalVenta();
        // Console.WriteLine($"\nTotal de la venta: {totalVenta}");
    }
}