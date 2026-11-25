namespace AutoDrive
{
    public class AutoElectrico : Vehiculo
    {
        public int Autonomia { get; set; }

        public AutoElectrico(string marca, int autonomia) : base(marca)
        {
            Autonomia = autonomia;
        }

        public override string Arrancar()
        {
            return $"[{Marca}] Sistema electrico activado en silencio. Autonomia: {Autonomia} km.";
        }
    }
}
