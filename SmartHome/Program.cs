using SmartHome;

List<Dispositivo> dispositivos = new List<Dispositivo>
{
    new AspiradoraRobot("Living", 0.6),
    new LamparaInteligente("Dormitorio", "Calido"),
    new Dispositivo("Cocina")
};

foreach (Dispositivo dispositivo in dispositivos)
{
    Console.WriteLine(dispositivo.EjecutarFuncion());
}
