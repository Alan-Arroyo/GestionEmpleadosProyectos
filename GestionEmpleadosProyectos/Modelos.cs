using System;

namespace GestionEmpleadosProyectos
{
    public class Empleado
    {
        public int IdEmpleado { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Cargo { get; set; } = string.Empty;
        public string Correo { get; set; } = string.Empty;
    }

    public class Proyecto
    {
        public int IdProyecto { get; set; }
        public string NombreProyecto { get; set; } = string.Empty;
        public DateTime FechaInicio { get; set; }
        public string Estado { get; set; } = "Activo";
    }

    public class Participacion
    {
        public int IdParticipacion { get; set; }
        public int IdEmpleado { get; set; }
        public string NombreEmpleado { get; set; } = string.Empty;
        public int IdProyecto { get; set; }
        public string NombreProyecto { get; set; } = string.Empty;
        public string RolEnProyecto { get; set; } = string.Empty;
        public DateTime FechaAsignacion { get; set; }
    }
}