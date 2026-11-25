using GrimorioMagico;

List<Hechizo> hechizos = new List<Hechizo>
{
    new BolaFuego("Ignis Maxima", 1200),
    new EscudoHielo("Glacies Murus", 5),
    new Hechizo("Lux Arcana")
};

foreach (Hechizo hechizo in hechizos)
{
    Console.WriteLine(hechizo.Lanzar());
}
