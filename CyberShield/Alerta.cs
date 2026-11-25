namespace CyberShield
{
    public class Alerta
    {
        private string codigo = string.Empty;

        public string Codigo
        {
            get => codigo;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("El codigo de alerta no puede estar vacio.");
                }
                codigo = value.Trim();
            }
        }

        public Alerta(string codigo)
        {
            Codigo = codigo;
        }

        public virtual string DispararProtocolo()
        {
            return $"[{Codigo}] Protocolo general de seguridad activado.";
        }
    }
}
