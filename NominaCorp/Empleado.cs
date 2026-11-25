namespace NominaCorp
{
    public class Empleado
    {
        private string idEmpleado = string.Empty;

        public string IdEmpleado
        {
            get => idEmpleado;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("El ID de empleado no puede estar vacio.");
                }
                idEmpleado = value.Trim();
            }
        }

        public Empleado(string idEmpleado)
        {
            IdEmpleado = idEmpleado;
        }

        public virtual string Trabajar()
        {
            return $"[ID {IdEmpleado}] Empleado realizando tareas asignadas.";
        }
    }
}
