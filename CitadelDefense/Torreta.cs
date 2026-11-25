namespace CitadelDefense
{
    public class Torreta
    {
        private string ubicacion = string.Empty;

        public string Ubicacion
        {
            get => ubicacion;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("La ubicacion no puede estar vacia.");
                }
                ubicacion = value.Trim();
            }
        }

        public Torreta(string ubicacion)
        {
            Ubicacion = ubicacion;
        }

        public virtual string Disparar()
        {
            return $"[{Ubicacion}] Torreta defensiva en posicion de disparo.";
        }
    }
}
