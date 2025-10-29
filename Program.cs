namespace FinalProgramacion
{
    internal class Program
    {
        //Constantes
        const int maxVehiculos = 20;
        const int maxClientes = 15;
        const int maxServicios = 5;

        //Arrays
        static string[] placas = new string[maxVehiculos];
        static int contarVehiculos = 0;

        static string[] nombresClientes = new string[maxClientes];
        static string[] telefonosClientes = new string[maxClientes];
        static string[] cedulasClientes = new string[maxClientes];
        static int contarClientes = 0;

        static string[,] servicios = new string[maxVehiculos, maxServicios];
        static double[,] costosServicios = new double[maxVehiculos, maxServicios];
        static int[] contarServicios = new int[maxVehiculos];

        static void Main()
        {
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("Gestion Taller Mecánico");
                Console.WriteLine("1. Registrar Vehículo");
                Console.WriteLine("2. Registrar Cliente");
                Console.WriteLine("3. Registrar Servicio");
                Console.WriteLine("4. Salir del programa");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        menuVehiculos();
                        break;
                    case 2:
                        menuClientes();
                        break;
                    case 3:
                        menuServicios();
                        break;
                    case 4:
                        Console.WriteLine("Presione una tecla para salir del programa");
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intente de nuevo.");
                        break;
                }

                if (opcion != 4)
                {
                    Console.WriteLine("Presione una tecla para continuar");
                    Console.ReadKey();
                }
            } while (opcion != 4);
        }

        //Menu Vehículos
        static void menuVehiculos()
        {
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("Gestión de Vehículos");
                Console.WriteLine("1. Registrar nuevo vehículo");
                Console.WriteLine("2. Ver lista de vehículos");
                Console.WriteLine("3. Editar vehículo por placa");
                Console.WriteLine("4. Salir al menú principal");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        registrarVehiculo();
                        break;
                    case 2:
                        verVehiculos();
                        break;
                    case 3:
                        editarVehiculo();
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intente de nuevo.");
                        break;
                }

                if (opcion != 4)
                {
                    Console.WriteLine("Presione una tecla para continuar");
                    Console.ReadKey();
                }
            } while (opcion != 4);
        }

        static string[] marcas = new string[maxVehiculos];
        static string[] modelos = new string[maxVehiculos];
        static int[] años = new int[maxVehiculos];

        static void registrarVehiculo()
        {
            if (contarVehiculos >= maxVehiculos)
            {
                Console.WriteLine("Capacidad máxima de vehículos alcanzada.");
                return;
            }

            Console.Write("Ingrese la placa del vehículo: ");
            string placa = Console.ReadLine();

            for (int i = 0; i < contarVehiculos; i++)
            {
                if (placas[i] == placa)
                {
                    Console.WriteLine("La placa ya está registrada.");
                    return;
                }
            }

            Console.Write("Ingrese la marca: ");
            string marca = Console.ReadLine();
            Console.Write("Ingrese el modelo: ");
            string modelo = Console.ReadLine();
            Console.Write("Ingrese el año: ");
            int año = int.Parse(Console.ReadLine());

            placas[contarVehiculos] = placa;
            marcas[contarVehiculos] = marca;
            modelos[contarVehiculos] = modelo;
            años[contarVehiculos] = año;
            contarVehiculos++;

            Console.WriteLine("Vehículo registrado exitosamente.");
        }

        static void verVehiculos()
        {
            
        }

        static void editarVehiculo()
        {
            
        }

        //Menu Clientes
        static void menuClientes()
        {
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("Gestion De Clientes");
                Console.WriteLine("1. Registrar Cliente");
                Console.WriteLine("2. Ver lista de clientes");
                Console.WriteLine("3. Buscar cliente por cedula");
                Console.WriteLine("4. Volver al menú principal");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        registrarCliente();
                        break;
                    case 2:
                        verClientes();
                        break;
                    case 3:
                        buscarCliente();
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intente de nuevo.");
                        break;
                }
                if (opcion != 4)
                {
                    Console.WriteLine("Presione una tecla para continuar");
                    Console.ReadKey();
                }
            } while (opcion != 4);
        }

        static void registrarCliente()
        {
            if (contarClientes >= maxClientes)
            {
                Console.WriteLine("Capacidad máxima de clientes alcanzada.");
                return;
            }
            Console.Write("Ingrese el nombre del cliente: ");
            string nombre = Console.ReadLine();
            Console.Write("Ingrese la cédula del cliente: ");
            string cedula = Console.ReadLine();

            int existe = 0;

            for (int i = 0; i < contarClientes; i++)
            {
                if (cedulasClientes[i] == cedula)
                {
                    existe = 1;
                }
            }

            if (existe == 1)
            {
                Console.WriteLine("La cédula ya está registrada.");
                return;
            }

            Console.Write("Ingrese Telefono: ");
            string telefono = Console.ReadLine();
            nombresClientes[contarClientes] = nombre;
            telefonosClientes[contarClientes] = telefono;
            cedulasClientes[contarClientes] = cedula;
            contarClientes++;

            Console.WriteLine("Cliente registrado exitosamente.");
        }

        static void verClientes()
        {
            if (contarClientes == 0)
            {
                Console.WriteLine("No hay clientes registrados.");
            }
            else
            {
                Console.WriteLine("Lista de Clientes:");
                for (int i = 0; i < contarClientes; i++)
                {
                    Console.WriteLine($"[{i + 1}] Nombre: {nombresClientes[i]}, Teléfono: {telefonosClientes[i]}, Cédula: {cedulasClientes[i]}");
                }
            }
        }

        static void buscarCliente()
        {
            Console.Write("Ingrese la cédula del cliente a buscar: ");
            string cedula = Console.ReadLine();
            int encontrado = 0;
            for (int i = 0; i < contarClientes; i++)
            {
                if (cedulasClientes[i] == cedula)
                {
                    Console.WriteLine($"Cliente encontrado: Nombre: {nombresClientes[i]}, Teléfono: {telefonosClientes[i]}, Cédula: {cedulasClientes[i]}");
                    encontrado = 1;
                    break;
                }
            }
            if (encontrado == 0)
            {
                Console.WriteLine("Cliente no encontrado.");
            }
        }

        //Menu Servicios
        static void menuServicios()
        {
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("Gestion De Servicios");
                Console.WriteLine("1. Registrar Servicio");
                Console.WriteLine("2. Ver lista de servicios por vehículo");
                Console.WriteLine("3. Volver al menú principal");
                Console.Write("Seleccione una opción: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        registrarServicio();
                        break;
                    case 2:
                        verServicios();
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intente de nuevo.");
                        break;
                }
                if (opcion != 3)
                {
                    Console.WriteLine("Presione una tecla para continuar");
                    Console.ReadKey();
                }
            } while (opcion != 3);
        }

        static void registrarServicio()
        {
            Console.Write("Ingrese placa del vehículo: ");
            string placaBuscada = Console.ReadLine();

            int indiceVehiculo = -1;
            for (int i = 0; i < contarVehiculos; i++)
            {
                if (placas[i] == placaBuscada)
                    indiceVehiculo = i;
            }
            if (indiceVehiculo == -1)
            {
                Console.WriteLine("Vehículo no encontrado.");
                return;
            }
            if (contarServicios[indiceVehiculo] >= maxServicios)
            {
                Console.WriteLine("Capacidad máxima de servicios para este vehículo alcanzada.");
                return;
            }
            Console.Write("Ingrese tipo de servicio: ");
            string tipoServicio = Console.ReadLine();

            Console.Write("Ingrese costo del servicio: ");
            double costoServicio = double.Parse(Console.ReadLine());

            int posicionServicio = contarServicios[indiceVehiculo];
            servicios[indiceVehiculo, posicionServicio] = tipoServicio;
            costosServicios[indiceVehiculo, posicionServicio] = costoServicio;
            contarServicios[indiceVehiculo]++;

            Console.WriteLine("Servicio registrado exitosamente.");

        }

        static void verServicios()
        {
            Console.Write("Ingrese placa del vehículo: ");
            string placaBuscada = Console.ReadLine();
            int indiceVehiculo = 0;
            for (int i = 0; i < contarVehiculos; i++)
            {
                if (placas[i] == placaBuscada)
                {
                    Console.WriteLine($"Servicios para el vehículo {placaBuscada}:");
                    indiceVehiculo = 1;

                    if (contarServicios[i] == 0)
                    {
                        Console.WriteLine("No hay servicios registrados para este vehículo.");
                    }
                    else
                    {
                        for (int j = 0; j < contarServicios[i]; j++)
                        {
                            Console.WriteLine($"Servicio: {j + 1}: {servicios[i, j]}, Costo: {costosServicios[i, j]}");
                        }
                    }
                }
            }
            if (indiceVehiculo == 0)
            {
                Console.WriteLine("Vehículo no encontrado.");
            }
        }
    }
}
