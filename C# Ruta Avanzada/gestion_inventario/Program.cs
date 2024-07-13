//Limpiamos la consola para poder trabajar de una manera mas limpia
Console.Clear();

//Declaro las variables del inicio del Ciclo, las elecciones y los contadores
bool run = true;
bool eleccionSTR = true;
string? eleccion;
int verProducto = 0;
int contador = 0;
int contadorProducto = 0;
int contadorProductoMostrar = 0;
string? nombreDado;
bool encontrado = false;
int contadorBusqueda = 0;

//Inicializamos las listas de cada producto
List<Dictionary<string, object>> productos =
[
    //Agregamos algunos valores quemados para facilidad del programa
    new Dictionary<string, object>{
            {"nombre", "coca cola"},
            {"valor", 1000},
            {"cantidad", 10}
        }
,
    new Dictionary<string, object> {
            {"nombre", "pan"},
            {"valor", 10000},
            {"cantidad", 150}
        }
,
    new Dictionary<string, object>{
            {"nombre", "monster"},
            {"valor", 9000},
            {"cantidad", 100}
        }
,
];


//Corremos el ciclo del programa
while (run)
{

    Console.WriteLine(@"
╔════════════════════════════════════════════════════════════════════════════════════════════════════╗
║                                                                                                    ║
║                                           INVENTARIO                                               ║
║                                                                                                    ║
╠════════════════════════════════════════════════════════════════════════════════════════════════════╣
║                                                                                                    ║
║     1. Agregar Producto                                                                            ║
║     2. Modificar Producto                                                                          ║
║     3. Eliminar Producto                                                                           ║
║     4. Listar Productos                                                                            ║
║     5. Buscar Productos                                                                            ║
║     6. Salir                                                                                       ║
║                                                                                                    ║
╚════════════════════════════════════════════════════════════════════════════════════════════════════╝");
    Console.Write("\nIngresa La opcion: ");
    eleccion = Console.ReadLine();

    //Ciclo a traves del cual llegado el caso que esta vacio pida de nuevo la informacion
    if (string.IsNullOrWhiteSpace(eleccion))
    {
        while (eleccionSTR)
        {
            Console.Write("\nIngresa una opcion valida: ");
            eleccion = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(eleccion))
            { //Este if verifica de nuevo que el objeto no esta vacio 
                eleccionSTR = false; //Cuando detecte que el objeto no esta vacio, inmediatamente sale del ciclo
            }
        }
    }

    switch (eleccion)
    {
        case "1":
            Console.Clear(); //Limpiamos la consola para mostrar los nuevos valores
            Console.WriteLine(@"
╔════════════════════════════════════════════════════════════════════════════════════════════════════╗
║                                                                                                    ║
║                                        AGREGAR PRODUCTOS                                           ║
║                                                                                                    ║
╠════════════════════════════════════════════════════════════════════════════════════════════════════╣
║       ║                             ║               ║                       ║                      ║
║  NRO  ║     NOMBRE DEL PRODUCTO     ║     VALOR     ║        CANTIDAD       ║        TOTAL         ║
║       ║                             ║               ║                       ║                      ║
╠════════════════════════════════════════════════════════════════════════════════════════════════════╣");
            verProducto = 0;
            foreach (var producto in productos)
            {//Este for each recorre la lista de objetos e imprime cada uno, junto con el valor del contador
                verProducto++;
                Console.WriteLine($"║   {verProducto,-4}║         {producto["nombre"],-20}║    {"$" + producto["valor"],-11}║          {producto["cantidad"],-13}║        {Convert.ToInt32(producto["cantidad"]) * Convert.ToInt32(producto["valor"]),-14}║");
            };

            Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════╝"); //Esta linea es con fines esteticos, para mostrar

            Console.WriteLine("\nAgregar Producto: ");

            Console.Write("\nIngrese el nombre del Producto => ");

            string? nombreProducto = Console.ReadLine().ToLower();

            if (string.IsNullOrWhiteSpace(nombreProducto))
            {//Verificacion de que el valor no este vacio, y si es asi entonces lleva de nuevo al menú
                Console.WriteLine("\nPor favor Ingresa algún valor valido");
                Console.Write("Presiona Calquier tecla para regresar al menú ");
                Console.ReadKey();
                Console.Clear();
                break;
            }

            Console.Write("Ingrese el valor por unidad => ");
            string? valorUnidadSTR = Console.ReadLine(); //Ingreso el dato como un string
            int ValorUnidad;//Declaro la variable a la cual se le va a dar el valor, dado el caso de que el TryParse si funcione
            bool valorUnidadBool = int.TryParse(valorUnidadSTR, out ValorUnidad);// si el Try parse funciona, le dara el valor a la variable antes mencionada

            if (!valorUnidadBool)
            {
                Console.WriteLine("\nPor favor Ingresa algún valor valido");
                Console.Write("Presiona Calquier tecla para regresar al menú ");
                Console.ReadKey();
                Console.Clear();
                break;
            }

            Console.Write("Ingrese la cantidad => ");
            string? cantidadSTR = Console.ReadLine(); //Ingreso el dato como un string
            int cantidad; //Declaro la variable a la cual se le va a dar el valor, dado el caso de que el TryParse si funcione
            bool cantidadBool = int.TryParse(cantidadSTR, out cantidad); // si el Try parse funciona, le dara el valor a la variable antes mencionada
            if (!cantidadBool)
            {
                Console.WriteLine("\nPor favor Ingresa algún valor");
                Console.Write("Presiona Calquier tecla para regresar al menú ");
                Console.ReadKey();
                Console.Clear();
                break;
            }

            //Creamos el Diccionario y lo enviamos
            productos.Add(
                new Dictionary<string, object> {

                    {"nombre", nombreProducto},
                    {"valor", ValorUnidad},
                    {"cantidad", cantidad}

                }
            );

            //Mensajes Finales
            Console.WriteLine("\n\nProducto Agregado Exitosamente");
            Console.Write("Presiona Calquier tecla para regresar al menú ");
            Console.ReadKey();
            Console.Clear();
            break;


        case "2":
            //Se limpia la consola para mostrar el nuevo valor
            Console.Clear();

            Console.WriteLine(@"
╔════════════════════════════════════════════════════════════════════════════════════════════════════╗
║                                                                                                    ║
║                                       MODIFICAR PRODUCTO                                           ║
║                                                                                                    ║
╠════════════════════════════════════════════════════════════════════════════════════════════════════╣
║       ║                             ║               ║                       ║                      ║
║  NRO  ║     NOMBRE DEL PRDUCTO      ║     VALOR     ║        CANTIDAD       ║        TOTAL         ║
║       ║                             ║               ║                       ║                      ║
╠════════════════════════════════════════════════════════════════════════════════════════════════════╣");
            contador = 0;
            foreach (var producto in productos)
            {
                contador++;
                Console.WriteLine($"║   {contador,-4}║         {producto["nombre"],-20}║    {"$" + producto["valor"],-11}║          {producto["cantidad"],-13}║        {Convert.ToInt32(producto["cantidad"]) * Convert.ToInt32(producto["valor"]),-14}║");
            };
            Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════╝");

            Console.Write("\nIngrese el numero del producto que desea modificar: (0 para salir) ");
            int numeroProducto = Convert.ToInt16(Console.ReadLine());

            if (numeroProducto == 0)
            {

                Console.Clear();

                break;

            }
            else
            {
                Console.WriteLine($"\n Has elegido {productos[numeroProducto - 1]["nombre"]} => ");
                Console.Write("\nQue quieres modificar? 1 => (nombre), 2 => (valor), 3 => (cantidad): ");

                string? eleccionModificarSTR = Console.ReadLine();



                switch (eleccionModificarSTR)
                {
                    case "1":
                        Console.Write("\nIngrese el nuevo nombre: ");
                        string? nuevoNombreProducto = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(nuevoNombreProducto))
                        {
                            Console.WriteLine("\nPor favor Ingresa algún valor valido");
                            Console.Write("Presiona Calquier tecla para regresar al menú ");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                        productos[numeroProducto - 1]["nombre"] = nuevoNombreProducto;
                        Console.WriteLine("Nombre Modificado Exitosamente");
                        Console.Write("Presione Cualquier Tecla para continuar ");
                        Console.ReadKey();
                        Console.Clear();
                        break;


                    case "2":
                        Console.Write("\nIngrese el nuevo valor: ");
                        string? nuevoValorProductoSTR = Console.ReadLine();
                        int nuevoValorProducto;
                        bool nuevoValorProductoBool = int.TryParse(nuevoValorProductoSTR, out nuevoValorProducto);
                        if (!nuevoValorProductoBool)
                        {
                            Console.WriteLine("\nPor favor Ingresa algún valor valido");
                            Console.Write("Presiona Calquier tecla para regresar al menú ");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }

                        productos[numeroProducto - 1]["valor"] = nuevoValorProducto;
                        Console.WriteLine("\nValor Modificado Exitosamente");
                        Console.Write("Presione Cualquier Tecla para continuar ");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "3":
                        Console.Write("\nIngrese la nueva cantidad: ");
                        string? nuevaCantidadProductoSTR = Console.ReadLine();
                        int nuevaCantidadProducto;
                        bool nuevaCantidadProductoBool = int.TryParse(nuevaCantidadProductoSTR, out nuevaCantidadProducto);
                        if (!nuevaCantidadProductoBool)
                        {
                            Console.WriteLine("\nPor favor Ingresa algún valor valido");
                            Console.Write("Presiona Calquier tecla para regresar al menú ");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                        productos[numeroProducto - 1]["cantidad"] = nuevaCantidadProducto;
                        Console.WriteLine("\nCantidad Modificada Exitosamente");
                        Console.Write("Presione Cualquier Tecla para continuar ");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine("\nError, valor no valido");
                        Console.Write("Presione Cualquier Tecla para continuar ");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }


            Console.Clear();

            break;


        case "3":
            Console.WriteLine("Eliminar Producto");
            Console.Clear();

            Console.WriteLine(@"
╔════════════════════════════════════════════════════════════════════════════════════════════════════╗
║                                                                                                    ║
║                                     ELIMINAR PRODUCTOS                                             ║
║                                                                                                    ║
╠════════════════════════════════════════════════════════════════════════════════════════════════════╣
║       ║                             ║               ║                       ║                      ║
║  NRO  ║     NOMBRE DEL PRDUCTO      ║     VALOR     ║        CANTIDAD       ║        TOTAL         ║
║       ║                             ║               ║                       ║                      ║
╠════════════════════════════════════════════════════════════════════════════════════════════════════╣");
            contadorProducto = 0;
            foreach (var producto in productos)
            {
                contadorProducto++;
                Console.WriteLine($"║   {contadorProducto,-4}║         {producto["nombre"],-20}║    {"$" + producto["valor"],-11}║          {producto["cantidad"],-13}║        {Convert.ToInt32(producto["cantidad"]) * Convert.ToInt32(producto["valor"]),-14}║");
            };
            Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════╝");

            Console.Write("\nIngrese el numero del producto que desea modificar: (0 para salir) ");
            string? numeroProductoEliminarSTR = Console.ReadLine();
            int numeroProductoEliminar;
            bool numeroProductoEliminarBool = int.TryParse(numeroProductoEliminarSTR, out numeroProductoEliminar);
            if (!numeroProductoEliminarBool)
            {
                Console.WriteLine("\nPor favor Ingresa algún valor valido");
                Console.Write("Presiona Calquier tecla para regresar al menú ");
                Console.ReadKey();
                Console.Clear();
                break;
            }
            if (numeroProductoEliminar == 0)
            {

                Console.Clear();

                break;

            }
            else
            {
                if (productos.Count > numeroProductoEliminar)
                {
                    productos.RemoveAt(numeroProductoEliminar - 1);
                    Console.WriteLine("\nProducto Eliminado Exitosamente");
                }
                else
                {
                    Console.WriteLine("\nPor favor Ingresa algún valor valido");
                    Console.Write("Presiona Calquier tecla para regresar al menú ");
                    Console.ReadKey();
                    Console.Clear();
                    break;
                }
            }
            Console.Write("Presione Cualquier Tecla para continuar");
            Console.ReadKey();
            Console.Clear();
            break;


        case "4":
            Console.WriteLine("Listar Productos");
            Console.Clear();

            Console.WriteLine(@"
╔════════════════════════════════════════════════════════════════════════════════════════════════════╗
║                                                                                                    ║
║                                          VER PRODUCTOS                                             ║
║                                                                                                    ║
╠════════════════════════════════════════════════════════════════════════════════════════════════════╣
║       ║                             ║               ║                       ║                      ║
║  NRO  ║     NOMBRE DEL PRDUCTO      ║     VALOR     ║        CANTIDAD       ║        TOTAL         ║
║       ║                             ║               ║                       ║                      ║
╠════════════════════════════════════════════════════════════════════════════════════════════════════╣");
            contadorProductoMostrar = 0;
            foreach (var producto in productos)
            {
                contadorProductoMostrar++;
                Console.WriteLine($"║   {contadorProductoMostrar,-4}║         {producto["nombre"],-20}║    {"$" + producto["valor"],-11}║          {producto["cantidad"],-13}║        {Convert.ToInt32(producto["cantidad"]) * Convert.ToInt32(producto["valor"]),-14}║");
            };
            Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════════════════════════════╝");

            Console.Write("\nPresione Cualquier Tecla para continuar ");
            Console.ReadKey();
            Console.Clear();
            break;


        case "5":
            Console.Clear();
            Console.WriteLine(@"
╔════════════════════════════════════════════════════════════════════════════════════════════════════╗
║                                                                                                    ║
║                                       BUSCAR PRODUCTOS                                             ║
║                                                                                                    ║
╚════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.Write("\nIngrese el nombre del Producto que quieres buscar => ");
            string? nombreBusqueda = Console.ReadLine().ToLower();
            if(string.IsNullOrWhiteSpace(nombreBusqueda)){
                Console.WriteLine("\nPor favor Ingresa algún valor valido");
                Console.Write("Presiona Calquier tecla para regresar al menú ");
                Console.ReadKey();
                Console.Clear();
                break;
            }
            foreach (var productoBusqueda in productos)
            {
                nombreDado = Convert.ToString(productoBusqueda["nombre"]);
                contadorBusqueda++;
                if (nombreDado == nombreBusqueda)
                {
                    Console.WriteLine(@$"
╔════════════════════════════════════════════════════════════════════════════════════════════════════╗
║       ║                             ║               ║                       ║                      ║
║  NRO  ║     NOMBRE DEL PRDUCTO      ║     VALOR     ║        CANTIDAD       ║        TOTAL         ║
║       ║                             ║               ║                       ║                      ║
╠════════════════════════════════════════════════════════════════════════════════════════════════════╣                     
║   {contadorBusqueda,-4}║         {productoBusqueda["nombre"],-20}║    {"$" + productoBusqueda["valor"],-11}║          {productoBusqueda["cantidad"],-13}║        {Convert.ToInt32(productoBusqueda["cantidad"]) * Convert.ToInt32(productoBusqueda["valor"]),-14}║
╚════════════════════════════════════════════════════════════════════════════════════════════════════╝");
                    encontrado = true;
                }
            }
            if (!encontrado)
            {
                Console.WriteLine("\n\nError, producto no encontrado");
            }
            Console.Write("\nPresione Cualquier Tecla para continuar ");
            Console.ReadKey();
            Console.Clear();
            break;


        case "6":
            Console.Clear();
            run = false;
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
            Console.WriteLine("\nPor Favor Ingrese Una opcion Valida");
            Console.Write("Presione Cualquier Tecla para continuar ");
            Console.ReadKey();
            Console.Clear();
            break;
    }

}
