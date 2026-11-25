namespace QuickDrop
{
    public class EnvioExpress : Envio
    {
        public int TiempoLimiteHoras { get; set; }

        public EnvioExpress(string direccion, int tiempoLimiteHoras) : base(direccion)
        {
            TiempoLimiteHoras = tiempoLimiteHoras;
        }

        public override string ProcesarEntrega()
        {
            return $"[{Direccion}] Prioridad express: entregar en menos de {TiempoLimiteHoras} horas.";
        }
    }
}
