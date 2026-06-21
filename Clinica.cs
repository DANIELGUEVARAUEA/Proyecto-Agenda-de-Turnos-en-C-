using System;
using System.IO;

namespace AgendaClinica
{
    // ============================
    // CLASE PRINCIPAL DEL SISTEMA
    // ============================
    public class Clinica
    {
        // VECTOR DE TURNOS
        private Turno[] agenda = new Turno[100];
        private int contador = 0;

        // MATRIZ DE HORARIOS
        private string[,] horarios = new string[7, 8];

        // ============================
        // CONSTRUCTOR
        // ============================
        public Clinica()
        {
            InicializarHorarios();
        }

        // Inicializa matriz
        private void InicializarHorarios()
        {
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    horarios[i, j] = "Disponible";
                }
            }
        }

        // ============================
        // AGREGAR TURNO
        // ============================
        public void AgregarTurno(Turno t)
        {
            agenda[contador] = t;
            contador++;

            ArchivoHelper.Guardar(t);

            Console.WriteLine("✔ Turno registrado correctamente");
        }

        // ============================
        // MOSTRAR TURNOS
        // ============================
        public void MostrarTurnos()
        {
            Console.WriteLine("\n===== LISTA DE TURNOS =====\n");

            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine($"ID: {agenda[i].Id}");
                Console.WriteLine($"Paciente: {agenda[i].NombrePaciente}");
                Console.WriteLine($"Médico: {agenda[i].Medico}");
                Console.WriteLine($"Especialidad: {agenda[i].Especialidad}");
                Console.WriteLine($"Fecha: {agenda[i].Fecha}");
                Console.WriteLine($"Hora: {agenda[i].Hora}");
                Console.WriteLine("----------------------");
            }
        }

        // ============================
        // BUSCAR TURNO
        // ============================
        public void BuscarTurno(string nombre)
        {
            bool encontrado = false;

            nombre = nombre ?? "";

            for (int i = 0; i < contador; i++)
            {
                if (agenda[i].NombrePaciente.ToLower() == nombre.ToLower())
                {
                    Console.WriteLine("✔ Turno encontrado:");
                    Console.WriteLine($"{agenda[i].Fecha} - {agenda[i].Hora}");
                    encontrado = true;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine(" No encontrado");
            }
        }

        // ============================
        // CARGAR DESDE ARCHIVO TXT
        // ============================
        public void CargarDesdeArchivo()
        {
            if (!File.Exists("turnos.txt"))
                return;

            string[] lineas = File.ReadAllLines("turnos.txt");

            foreach (string linea in lineas)
            {
                string[] datos = linea.Split(',');

                if (datos.Length < 6) continue;

                Turno t = new Turno();

                t.Id = int.Parse(datos[0]);
                t.NombrePaciente = datos[1];
                t.Medico = datos[2];
                t.Especialidad = datos[3];
                t.Fecha = datos[4];
                t.Hora = datos[5];

                agenda[contador] = t;
                contador++;
            }
        }
    }
}