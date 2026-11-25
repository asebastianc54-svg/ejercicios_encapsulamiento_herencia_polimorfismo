namespace AutoDrive
{
    public class Camioneta : Vehiculo
    {
        public bool Traccion4x4 { get; set; }

        public Camioneta(string marca, bool traccion4x4) : base(marca)
        {
            Traccion4x4 = traccion4x4;
        }

        public override string Arrancar()
        {
            string modo = Traccion4x4 ? "4x4 acoplada" : "traccion simple";
            return $"[{Marca}] Motor de camioneta encendido con {modo}.";
        }
    }
}
