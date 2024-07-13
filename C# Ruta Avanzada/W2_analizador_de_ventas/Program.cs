

//Creamos la clase
using System;

public class Ventas
{
    public int Id;
    public string? Fecha;
    public double ValorProducto;
    public int CantidadProducto;
    public string? Vendedor;
    public string? Comprador;
    public byte TiempoGarantia;
    public Ventas(int id, string fecha, double valorProducto, int cantidadProducto, string vendedor, string comprador, byte tiempoGarantia)
    {
        this.Id = id;
        this.Fecha = fecha;
        this.ValorProducto = valorProducto;
        this.CantidadProducto = cantidadProducto;
        this.Vendedor = vendedor;
        this.Comprador = comprador;
        this.TiempoGarantia = tiempoGarantia;
    }

    public Int32 TotalVenta()
    {
        return (int)(this.ValorProducto * this.CantidadProducto);
    }


}

class Principal
{
    static void Main(string[] args)
    {

        Console.ForegroundColor = ConsoleColor.DarkCyan;
        bool run = true;
        string? eleccion;
        List<Ventas> ventas = new List<Ventas>();
        int id = 0;
        while (run)
        {
            Console.Clear();
            Console.WriteLine(@"
╔════════════════════════════════════════════════════════════════════════════════════════════════════╗
║                                                                                                    ║
║                                     ANALIZADOR DE VENTAS                                           ║
║                                                                                                    ║
╠════════════════════════════════════════════════════════════════════════════════════════════════════╣
║                                                                                                    ║
║     1. Agregar Ventas                                                                              ║
║     2. Valor De Una Venta                                                                          ║
║     3. Promedio De Ventas Diarias                                                                  ║
║     4. Ver Empleado Del Mes                                                                        ║
║     5. Cliente Del Mes                                                                             ║
║     6. Ver Ventas En Periodo De Tiempo                                                             ║
║     7. Ver Todas Las Ventas Realizadas Después De Una Fecha Específica                             ║
║     8. Filtarar vendedores Que Realizaron Ventas Por Encima De Cierto Valor                        ║
║     9. Agrupar Las Ventas Por Mes y Calcular El Total De Ventas Mensuales                          ║
║     10. Encontrar El Vendedor Con El Mayor Número De Ventas En Un Período Específico               ║
║     11. Ordenar Las Ventas Por Valor Total Descendente y Mostrar Las Primeras 'N' Ventas           ║
║     12. Encontrar Los Productos Más Vendidos Por Cantidad En Un Año Determinado                    ║
║     13. Validar Si Existe Alguna Venta Con Un Valor Específico                                     ║
║     14. Buscar Todas Las Ventas Realizadas a Un Cliente Específico                                 ║
║     15. Datos De Ventas Por Vendedor                                                               ║
║     16. Mostrar El Mes Con Mayor Numero De Ventas                                                  ║
║     17. Salir                                                                                      ║
║                                                                                                    ║
╚════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.Write("\nEliga la Opcion Que Deseas Realizar => ");
            eleccion = Console.ReadLine();
            switch (eleccion)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine(@"
╔════════════════════════════════════════════════════════════════════════════════════════════════════╗
║                                                                                                    ║
║                                         AGREGAR VENTAS                                             ║
║                                                                                                    ║
╚════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                    // Pedir al usuario que ingrese una fecha
                    Console.Write("Ingrese la fecha de venta (formato dd/MM/yyyy) => ");
                    string? inputFecha = Console.ReadLine();
                    string? fechaFormateada;
                    // Convertir la entrada del usuario a DateTime
                    if (DateTime.TryParseExact(inputFecha, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime fecha))
                    {
                        // Formatear la fecha como una cadena con el formato deseado
                        fechaFormateada = fecha.ToString("yyyy-MM-dd");
                    }
                    else
                    {
                        Console.WriteLine("Formato de fecha incorrecto. Ingrese una fecha en formato dd/MM/yyyy.");
                        Console.Write("Presione cualquier tecla para continuar => ");
                        Console.ReadKey();
                        break;
                    }
                    Console.Write("Ingrese el valor del producto => ");
                    double valorProducto = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingresa la cantidad del producto => ");
                    int cantidadProducto = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Ingrese el nombre del vendedor => ");
                    string? nombreVendedor = Console.ReadLine().Trim().ToLower();
                    if (string.IsNullOrWhiteSpace(nombreVendedor))
                    {
                        Console.Write("Ingrese por favor algun valor => ");
                        Console.ReadKey();
                    }
                    Console.Write("Ingrese el nombre del comprador => ");
                    string nombreComprador = Console.ReadLine().Trim().ToLower();
                    if (string.IsNullOrWhiteSpace(nombreComprador))
                    {
                        Console.Write("Ingrese por favor algun valor => ");
                        Console.ReadKey();
                    }
                    Console.Write("Ingrese el tiempo de garantia (en meses) => ");
                    byte garantia = Convert.ToByte(Console.ReadLine());

                    var ventaObj = new Ventas(id, fechaFormateada, valorProducto, cantidadProducto, nombreVendedor, nombreComprador, garantia);
                    ventas.Add(ventaObj);

                    Console.WriteLine("\nProducto agregado Exitosamente");
                    Console.Write("Presione cualquier tecla para regresar al menu => ");
                    Console.ReadKey();

                    id++;
                    break;


                case "2":
                    Console.Clear();
                    Console.WriteLine(@"
╔════════════════════════════════════════════════════════════════════════════════════════════════════╗
║                                                                                                    ║
║                                        VER VALOR DE UNA VENTA                                      ║
║                                                                                                    ║
╚════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                    Console.Write("\nIngrese el id de la venta => ");
                    string? eleccionVenta = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(eleccionVenta))
                    {
                        Console.WriteLine("\nPor favor ingrese un valor valido");
                        Console.Write("Presiona cualquier tecla para continuar => ");
                        Console.ReadKey();
                        break;
                    }
                    bool encontrado = false;
                    foreach (var item in ventas)
                    {
                        if (item.Id == Convert.ToInt16(eleccionVenta))
                        {
                            Console.WriteLine("\nProducto Encontrado");
                            Console.WriteLine($"\nFecha de Venta: {item.Fecha}");
                            Console.WriteLine($"Valor Producto: {item.ValorProducto}");
                            Console.WriteLine($"Cantidad Unidades: {item.CantidadProducto}");
                            Console.WriteLine($"Vendedor: {item.Vendedor}");
                            Console.WriteLine($"Comprador: {item.Comprador}");
                            Console.WriteLine($"Valor Total: {item.TotalVenta()}");
                            encontrado = true;
                            break;
                        }
                    }
                    if (!encontrado)
                    {
                        Console.WriteLine("\nProducto No encontrado");
                    }
                    Console.Write("\nPresiona cualquier tecla para continuar => ");
                    Console.ReadKey();
                    break;


                case "3":
                    Console.Clear();
                    Console.WriteLine(@"
╔════════════════════════════════════════════════════════════════════════════════════════════════════╗
║                                                                                                    ║
║                                         AGREGAR VENTAS                                             ║
║                                                                                                    ║
╚════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                    Console.Write("Ingresa la fecha de la cual quieres sacar el promedio de ventas (yyyy-MM-dd) => ");
                    string? fechaDiaria = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(fechaDiaria))
                    {
                        Console.WriteLine("Formato de fecha incorrecto. Ingrese una fecha en formato dd/MM/yyyy.");
                        Console.Write("Presione cualquier tecla para continuar => ");
                        Console.ReadKey();
                        break;
                    }
                    var diarias = ventas.Where(v => v.Fecha == fechaDiaria).Select(v => v.TotalVenta()).ToList();
                    double promedioVentasDiaria = diarias.Average();
                    Console.WriteLine($"\nEl promedio de ventas de la fecha {fechaDiaria} es de {promedioVentasDiaria}");
                    Console.Write("\nPresione cualquier tecla para continuar => ");
                    Console.ReadKey();
                    break;


                case "4":
                    Console.Clear();
                    Console.WriteLine("Ingrese el mes del cual quieres ver el mejor empleado (MM): ");
                    string mesEmpleadoMes = Console.ReadLine();

                    var ventasMes = ventas.Where(v => v.Fecha.Substring(5, 2) == mesEmpleadoMes).ToList();
                    var empleadoDelMes = ventasMes.GroupBy(v => v.Vendedor)
                                                  .OrderByDescending(g => g.Sum(v => v.TotalVenta()))
                                                  .FirstOrDefault();

                    if (empleadoDelMes != null)
                    {
                        Console.WriteLine($"El empleado del mes es: {empleadoDelMes.Key}");
                    }
                    else
                    {
                        Console.WriteLine("No hay datos suficientes para determinar el empleado del mes.");
                    }
                    Console.Write("\nPresione cualquier tecla para continuar => ");
                    Console.ReadKey();
                    break;


                case "5":
                    //AUN FALTA CORREGIRLO 

                    break;


                case "6":
                    Console.Clear();
                    Console.WriteLine(@"
╔════════════════════════════════════════════════════════════════════════════════════════════════════╗
║                                                                                                    ║
║                               FILTRAR VENTAS POR PERIODO DE TIEMPO                                 ║
║                                                                                                    ║
╚════════════════════════════════════════════════════════════════════════════════════════════════════╝");

                    Console.Write("\nIngresa la fecha inicial (yyyy-MM-dd) => ");
                    string? fechaInicialPeriodo = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(fechaInicialPeriodo))
                    {
                        Console.WriteLine("Fecha inicial no válida.");
                        Console.Write("Presione cualquier tecla para continuar => ");
                        Console.ReadKey();
                        break;
                    }

                    Console.Write("\nIngresa la fecha final (yyyy-MM-dd) => ");
                    string? fechaFinalPeriodo = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(fechaFinalPeriodo))
                    {
                        Console.WriteLine("Fecha final no válida.");
                        Console.Write("Presione cualquier tecla para continuar => ");
                        Console.ReadKey();
                        break;
                    }

                    DateTime fechaInicial, fechaFinal;

                    if (!DateTime.TryParseExact(fechaInicialPeriodo, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out fechaInicial))
                    {
                        Console.WriteLine("Formato de fecha inicial incorrecto. Ingrese una fecha en formato yyyy-MM-dd.");
                        Console.Write("Presione cualquier tecla para continuar => ");
                        Console.ReadKey();
                        break;
                    }

                    if (!DateTime.TryParseExact(fechaFinalPeriodo, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out fechaFinal))
                    {
                        Console.WriteLine("Formato de fecha final incorrecto. Ingrese una fecha en formato yyyy-MM-dd.");
                        Console.Write("Presione cualquier tecla para continuar => ");
                        Console.ReadKey();
                        break;
                    }

                    // Filtrar las ventas por el período de tiempo especificado
                    var ventasPeriodo = ventas.Where(v =>
                        DateTime.ParseExact(v.Fecha, "yyyy-MM-dd", null) >= fechaInicial &&
                        DateTime.ParseExact(v.Fecha, "yyyy-MM-dd", null) <= fechaFinal
                    ).ToList();

                    // Mostrar las ventas encontradas en el período
                    if (ventasPeriodo.Any())
                    {
                        Console.WriteLine("\nVentas encontradas en el período especificado:");
                        foreach (var venta in ventasPeriodo)
                        {
                            Console.WriteLine($"- Fecha: {venta.Fecha}, Vendedor: {venta.Vendedor}, Total: {venta.TotalVenta()}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nNo se encontraron ventas en el período especificado.");
                    }

                    Console.Write("\nPresione cualquier tecla para continuar => ");
                    Console.ReadKey();
                    break;



                case "7":
                    break;


                case "8":
                    break;


                case "9":
                    break;


                case "10":
                    break;


                case "11":
                    break;


                case "12":
                    break;


                case "13":
                    break;


                case "14":
                    break;


                case "15":
                    break;


                case "16":
                    break;


                case "17":
                    run = false;
                    Console.Clear();
                    Console.WriteLine(@"
 ╔════════════════════════════════════════════════════════════════════════════╗
 ║                                                                            ║
 ║    ╭──────────────────────────────────────────────────────────────────╮    ║
 ║    │                             Adiós!                               │    ║
 ║    │                                                                  │    ║
 ║    │                         By Juan Zuluaga                          │    ║
 ║    │                                                                  │    ║
 ║    │                 Gracias por usar este programa!                  │    ║
 ║    ╰──────────────────────────────────────────────────────────────────╯    ║
 ║                                                                            ║
 ╚════════════════════════════════════════════════════════════════════════════╝
            ");
                    break;


                default:
                    break;
            }
        }
    }
}
