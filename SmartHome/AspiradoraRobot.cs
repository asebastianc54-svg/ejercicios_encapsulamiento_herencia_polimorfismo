namespace SmartHome
{
    public class AspiradoraRobot : Dispositivo
    {
        public double CapacidadTanque { get; set; }

        public AspiradoraRobot(string habitacion, double capacidadTanque) : base(habitacion)
        {
            CapacidadTanque = capacidadTanque;
        }

        public override string EjecutarFuncion()
        {
            return $"[{Habitacion}] Aspiradora robot aspirando el piso (tanque de {CapacidadTanque} L).";
        }
    }
}
