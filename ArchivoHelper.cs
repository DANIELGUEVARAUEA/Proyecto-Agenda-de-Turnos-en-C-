using System;
using System.IO;

namespace AgendaClinica
{
    // ============================
    // MANEJO DE ARCHIVO TXT
    // ============================
    public static class ArchivoHelper
    {
        // Guardar turno en archivo
        public static void Guardar(Turno t)
        {
            using (StreamWriter sw = new StreamWriter("turnos.txt", true))
            {
                sw.WriteLine($"{t.Id},{t.NombrePaciente},{t.Medico},{t.Especialidad},{t.Fecha},{t.Hora}");
            }
        }
    }
}