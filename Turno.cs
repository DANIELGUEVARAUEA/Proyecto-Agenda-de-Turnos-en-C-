using System;

namespace AgendaClinica
{
    // ============================
    // STRUCT: REPRESENTA UN TURNO
    // ============================
    // Funciona como un registro de datos del paciente
    public struct Turno
    {
        public int Id;                 // Identificador del turno
        public string NombrePaciente;  // Nombre del paciente
        public string Medico;         // Médico asignado
        public string Especialidad;   // Especialidad médica
        public string Fecha;          // Fecha del turno
        public string Hora;           // Hora del turno
    }
}