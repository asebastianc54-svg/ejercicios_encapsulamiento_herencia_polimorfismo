namespace CyberShield
{
    public class IntrusionRed : Alerta
    {
        public string IpOrigen { get; set; } = string.Empty;

        public IntrusionRed(string codigo, string ipOrigen) : base(codigo)
        {
            IpOrigen = ipOrigen;
        }

        public override string DispararProtocolo()
        {
            return $"[{Codigo}] Bloqueando conexion sospechosa desde la IP {IpOrigen}.";
        }
    }
}
