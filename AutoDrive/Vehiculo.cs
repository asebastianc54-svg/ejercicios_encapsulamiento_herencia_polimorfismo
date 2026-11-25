namespace AutoDrive
{
    public class Vehiculo
    {
        private string marca = string.Empty;

        public string Marca
        {
            get => marca;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("La marca no puede estar vacia.");
                }
                marca = value.Trim();
            }
        }

        public Vehiculo(string marca)
        {
            Marca = marca;
        }

        public virtual string Arrancar()
        {
            return $"[{Marca}] El vehiculo esta iniciando el encendido.";
        }
    }
}
