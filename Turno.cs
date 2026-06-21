using System;

namespace AgendaClinica
{
    // ============================
    // STRUCT: REGISTRO DE TURNO
    // ============================
    public struct Turno
    {
        public int Id;                 // Identificador único
        public string NombrePaciente;  // Nombre del paciente
        public string Medico;          // Médico asignado
        public string Especialidad;    // Especialidad médica
        public string Fecha;           // Fecha del turno
        public string Hora;            // Hora del turno
    }
}