namespace QuickDrop
{
    public class EnvioFragil : Envio
    {
        public string MaterialProteccion { get; set; } = string.Empty;

        public EnvioFragil(string direccion, string materialProteccion) : base(direccion)
        {
            MaterialProteccion = materialProteccion;
        }

        public override string ProcesarEntrega()
        {
            return $"[{Direccion}] Manipulacion cuidadosa con proteccion de {MaterialProteccion}.";
        }
    }
}
