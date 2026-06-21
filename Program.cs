using System;

namespace AgendaClinica
{
    // ============================
    // CLASE PRINCIPAL DEL PROGRAMA
    // ============================
    class Program
    {
        // ============================
        // MÉTODO PRINCIPAL (ENTRY POINT)
        // ============================
        static void Main(string[] args)
        {
            // Creamos una instancia de la clase Clinica
            Clinica clinica = new Clinica();

            // Variable para manejar opciones del menú
            int opcion;

            // ============================
            // MENÚ PRINCIPAL (CICLO DO WHILE)
            // ============================
            do
            {
                Console.WriteLine("\n===== SISTEMA DE TURNOS CLÍNICA =====");
                Console.WriteLine("1. Agregar turno");
                Console.WriteLine("2. Mostrar turnos");
                Console.WriteLine("3. Buscar turno por paciente");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");

                // Leemos la opción del usuario
                opcion = int.Parse(Console.ReadLine());

                // ============================
                // ESTRUCTURA DE CONTROL SWITCH
                // ============================
                switch (opcion)
                {
                    // ============================
                    // OPCIÓN 1: AGREGAR TURNO
                    // ============================
                    case 1:

                        // Creamos un objeto tipo Turno (struct)
                        Turno t;

                        Console.WriteLine("\n--- REGISTRAR TURNO ---");

                        Console.Write("ID: ");
                        t.Id = int.Parse(Console.ReadLine());

                        Console.Write("Nombre del paciente: ");
                        t.NombrePaciente = Console.ReadLine();

                        Console.Write("Médico: ");
                        t.Medico = Console.ReadLine();

                        Console.Write("Especialidad: ");
                        t.Especialidad = Console.ReadLine();

                        Console.Write("Fecha (dd/mm/aaaa): ");
                        t.Fecha = Console.ReadLine();

                        Console.Write("Hora: ");
                        t.Hora = Console.ReadLine();

                        // Enviamos el turno a la clase Clinica
                        clinica.AgregarTurno(t);

                        break;

                    // ============================
                    // OPCIÓN 2: MOSTRAR TURNOS
                    // ============================
                    case 2:
                        clinica.MostrarTurnos();
                        break;

                    // ============================
                    // OPCIÓN 3: BUSCAR TURNO
                    // ============================
                    case 3:

                        Console.Write("\nIngrese nombre del paciente: ");
                        string nombre = Console.ReadLine();

                        clinica.BuscarTurno(nombre);

                        break;

                    // ============================
                    // OPCIÓN 4: SALIR
                    // ============================
                    case 4:
                        Console.WriteLine("Saliendo del sistema... ");
                        break;

                    // ============================
                    // OPCIÓN INVÁLIDA
                    // ============================
                    default:
                        Console.WriteLine("❌ Opción inválida, intente nuevamente.");
                        break;
                }

            } while (opcion != 4); // El programa se repite hasta que el usuario salga
        }
    }
}