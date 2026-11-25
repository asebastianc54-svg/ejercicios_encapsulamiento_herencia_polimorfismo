using CitadelDefense;

List<Torreta> torretas = new List<Torreta>
{
    new TorretaLaser("Muralla Norte", 92),
    new Lanzamisiles("Torre Este", 8),
    new Torreta("Puerta Sur")
};

foreach (Torreta torreta in torretas)
{
    Console.WriteLine(torreta.Disparar());
}
