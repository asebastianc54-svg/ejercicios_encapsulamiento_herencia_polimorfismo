using CyberShield;

List<Alerta> alertas = new List<Alerta>
{
    new IntrusionRed("SEC-01", "192.168.1.77"),
    new MalwareDetectado("SEC-02", "C:\\Temp\\payload.exe"),
    new Alerta("SEC-03")
};

foreach (Alerta alerta in alertas)
{
    Console.WriteLine(alerta.DispararProtocolo());
}
