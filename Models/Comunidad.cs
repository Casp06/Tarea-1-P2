namespace MiembrosComunidadApp.Models
{
    public class MiembroDeLaComunidad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Identificacion { get; set; }

        public virtual string ObtenerRol()
        {
            return "Miembro de la Comunidad";
        }
    }

    public class Estudiante : MiembroDeLaComunidad
    {
        public string Carrera { get; set; }

        public override string ObtenerRol()
        {
            return "Estudiante";
        }
    }

    public class ExAlumno : MiembroDeLaComunidad
    {
        public int AñoDeGraduacion { get; set; }

        public override string ObtenerRol()
        {
            return "Ex-Alumno";
        }
    }

    public class Empleado : MiembroDeLaComunidad
    {
        public string Departamento { get; set; }

        public override string ObtenerRol()
        {
            return "Empleado";
        }
    }

    public class Docente : Empleado
    {
        public string AreaDeEnseñanza { get; set; }

        public override string ObtenerRol()
        {
            return "Docente";
        }
    }

    public class Administrativo : Empleado
    {
        public override string ObtenerRol()
        {
            return "Administrativo";
        }
    }

    public class Administrador : Empleado
    {
        public string NivelDeAcceso { get; set; }

        public override string ObtenerRol()
        {
            return "Administrador";
        }
    }

    public class Maestro : Docente
    {
        public string NivelDeGrado { get; set; } 

        public override string ObtenerRol()
        {
            return "Maestro";
        }
    }
}
