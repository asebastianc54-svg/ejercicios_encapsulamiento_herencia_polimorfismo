namespace QuickDrop
{
    public class Envio
    {
        private string direccion = string.Empty;

        public string Direccion
        {
            get => direccion;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("La direccion no puede estar vacia.");
                }
                direccion = value.Trim();
            }
        }

        public Envio(string direccion)
        {
            Direccion = direccion;
        }

        public virtual string ProcesarEntrega()
        {
            return $"[{Direccion}] Procesando envio estandar.";
        }
    }
}
