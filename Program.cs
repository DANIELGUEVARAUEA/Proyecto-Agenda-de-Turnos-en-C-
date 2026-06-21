using System;

namespace AgendaClinica
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear sistema
            Clinica clinica = new Clinica();

            // Cargar datos guardados
            clinica.CargarDesdeArchivo();

            int opcion = 0;

            do
            {
                Console.WriteLine("\n===== SISTEMA CLÍNICA =====");
                Console.WriteLine("1. Agregar turno");
                Console.WriteLine("2. Mostrar turnos");
                Console.WriteLine("3. Buscar turno");
                Console.WriteLine("4. Salir");
                Console.Write("Opción: ");

                // FIX: sin warning null
                string? input = Console.ReadLine();

                while (!int.TryParse(input, out opcion))
                {
                    Console.Write(" Ingrese número válido: ");
                    input = Console.ReadLine();
                }

                switch (opcion)
                {
                    case 1:
                        Turno t;

                        Console.Write("ID: ");
                        string? idInput = Console.ReadLine();
                        int.TryParse(idInput, out t.Id);

                        Console.Write("Paciente: ");
                        t.NombrePaciente = Console.ReadLine() ?? "";

                        Console.Write("Médico: ");
                        t.Medico = Console.ReadLine() ?? "";

                        Console.Write("Especialidad: ");
                        t.Especialidad = Console.ReadLine() ?? "";

                        Console.Write("Fecha: ");
                        t.Fecha = Console.ReadLine() ?? "";

                        Console.Write("Hora: ");
                        t.Hora = Console.ReadLine() ?? "";

                        clinica.AgregarTurno(t);
                        break;

                    case 2:
                        clinica.MostrarTurnos();
                        break;

                    case 3:
                        Console.Write("Nombre paciente: ");
                        string nombre = Console.ReadLine() ?? "";
                        clinica.BuscarTurno(nombre);
                        break;

                    case 4:
                        Console.WriteLine("Saliendo...");
                        break;

                    default:
                        Console.WriteLine("Opción inválida");
                        break;
                }

            } while (opcion != 4);
        }
    }
}