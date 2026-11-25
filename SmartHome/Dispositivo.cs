namespace SmartHome
{
    public class Dispositivo
    {
        private string habitacion = string.Empty;

        public string Habitacion
        {
            get => habitacion;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("La habitacion no puede estar vacia.");
                }
                habitacion = value.Trim();
            }
        }

        public Dispositivo(string habitacion)
        {
            Habitacion = habitacion;
        }

        public virtual string EjecutarFuncion()
        {
            return $"[{Habitacion}] Dispositivo inteligente ejecutando rutina.";
        }
    }
}
