using ToyFactory;

List<Juguete> juguetes = new List<Juguete>
{
    new Muñeca("TOY-501", "Nylon"),
    new AutoControl("TOY-502", 2.4),
    new Juguete("TOY-503")
};

foreach (Juguete juguete in juguetes)
{
    Console.WriteLine(juguete.ProbarJuguete());
}
