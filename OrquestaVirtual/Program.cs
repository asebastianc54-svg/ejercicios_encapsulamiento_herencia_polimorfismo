using OrquestaVirtual;

List<Instrumento> instrumentos = new List<Instrumento>
{
    new Guitarra("Fender Stratocaster", 6),
    new Piano("Yamaha P-125", 88),
    new Instrumento("Teclado Generico")
};

foreach (Instrumento instrumento in instrumentos)
{
    Console.WriteLine(instrumento.TocarNota());
}
