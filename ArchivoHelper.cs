using System;
using System.IO;

namespace AgendaClinica
{
    // ============================
    // CLASE PARA MANEJO DE ARCHIVOS
    // ============================
    public static class ArchivoHelper
    {
        // ============================
        // GUARDAR TURNO EN TXT
        // ============================
        public static void Guardar(Turno t)
        {
            // using = libera memoria automáticamente
            using (StreamWriter sw = new StreamWriter("turnos.txt", true))
            {
                sw.WriteLine(
                    $"{t.Id},{t.NombrePaciente},{t.Medico},{t.Especialidad},{t.Fecha},{t.Hora}"
                );
            }
        }
    }
}