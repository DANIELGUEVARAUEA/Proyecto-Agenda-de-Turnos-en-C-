using System;

namespace AgendaClinica
{
    // ============================
    // CLASE PRINCIPAL DEL SISTEMA
    // ============================
    public class Clinica
    {
        // VECTOR (arreglo) para almacenar turnos
        private Turno[] agenda = new Turno[100];

        // contador de registros
        private int contador = 0;

        // MATRIZ (control de horarios)
        private string[,] horarios = new string[7, 8];

        // ============================
        // CONSTRUCTOR
        // ============================
        public Clinica()
        {
            InicializarHorarios();
        }

        // ============================
        // INICIALIZA MATRIZ DE HORARIOS
        // ============================
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
            if (contador < agenda.Length)
            {
                agenda[contador] = t;
                contador++;

                // guardar en archivo
                ArchivoHelper.Guardar(t);

                Console.WriteLine("✔ Turno registrado correctamente.\n");
            }
            else
            {
                Console.WriteLine("❌ Agenda llena.");
            }
        }

        // ============================
        // MOSTRAR TURNOS (REPORTE)
        // ============================
        public void MostrarTurnos()
        {
            Console.WriteLine("\n===== REPORTE DE TURNOS =====\n");

            for (int i = 0; i < contador; i++)
            {
                Console.WriteLine($"ID: {agenda[i].Id}");
                Console.WriteLine($"Paciente: {agenda[i].NombrePaciente}");
                Console.WriteLine($"Médico: {agenda[i].Medico}");
                Console.WriteLine($"Especialidad: {agenda[i].Especialidad}");
                Console.WriteLine($"Fecha: {agenda[i].Fecha}");
                Console.WriteLine($"Hora: {agenda[i].Hora}");
                Console.WriteLine("---------------------------");
            }
        }

        // ============================
        // BUSCAR POR PACIENTE
        // ============================
        public void BuscarTurno(string nombre)
        {
            bool encontrado = false;

            for (int i = 0; i < contador; i++)
            {
                if (agenda[i].NombrePaciente.ToLower() == nombre.ToLower())
                {
                    Console.WriteLine("\n✔ Turno encontrado:");
                    Console.WriteLine($"Fecha: {agenda[i].Fecha}");
                    Console.WriteLine($"Hora: {agenda[i].Hora}");
                    encontrado = true;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("❌ No se encontró el paciente.");
            }
        }
    }
}