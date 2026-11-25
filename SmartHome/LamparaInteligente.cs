namespace SmartHome
{
    public class LamparaInteligente : Dispositivo
    {
        public string ColorLed { get; set; } = string.Empty;

        public LamparaInteligente(string habitacion, string colorLed) : base(habitacion)
        {
            ColorLed = colorLed;
        }

        public override string EjecutarFuncion()
        {
            return $"[{Habitacion}] Lampara inteligente encendida en tono {ColorLed}.";
        }
    }
}
