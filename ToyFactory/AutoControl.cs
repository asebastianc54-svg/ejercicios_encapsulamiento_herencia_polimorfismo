namespace ToyFactory
{
    public class AutoControl : Juguete
    {
        public double Frecuencia { get; set; }

        public AutoControl(string numeroSerie, double frecuencia) : base(numeroSerie)
        {
            Frecuencia = frecuencia;
        }

        public override string ProbarJuguete()
        {
            return $"[SN {NumeroSerie}] Probando direccion y enlace radial a {Frecuencia} MHz.";
        }
    }
}
