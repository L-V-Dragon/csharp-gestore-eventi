using csharp_gestore_eventi;

try
{
    Console.WriteLine("Creiamo un evento");
    Console.WriteLine();

    Console.WriteLine("Inserisci il titolo");
    string titolo = Console.ReadLine();
    Console.WriteLine();

    Console.WriteLine("Inserisci una data (GG/MM/YYYY)");
    string data = Console.ReadLine();
    Console.WriteLine();

    Console.WriteLine("Inserisci il numero di posti totali");
    int capMax = int.Parse(Console.ReadLine());
    Console.WriteLine();

    Console.WriteLine("Quanti posti vuoi prenotare?");
    int nPrenotazioni = int.Parse(Console.ReadLine());
    Console.WriteLine();

    Evento Eventoutente = new Evento(titolo, data, capMax);
    Eventoutente.PrenotaPosti(nPrenotazioni);
    Console.WriteLine(Eventoutente);
    Console.WriteLine("Capienza Massima Evento: " + Eventoutente.GetCapMax());
    Console.WriteLine("Numero Posti Prenotati: " + Eventoutente.GetNPrenotazioni());
    Console.WriteLine();

    Console.WriteLine("Vuoi disdire delle prenotazioni? s/n");
    Console.WriteLine();

    while (Console.ReadLine() == "s")
    {
        Console.WriteLine("Quanti prenotazioni vuoi disdire?");
        int postiDisdetti = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Eventoutente.DisdiciPosti(postiDisdetti);
        Console.WriteLine(Eventoutente);
        Console.WriteLine("Capienza Massima Evento: " + Eventoutente.GetCapMax());
        Console.WriteLine("Numero Posti Prenotati: " + Eventoutente.GetNPrenotazioni());
        Console.WriteLine();

        Console.WriteLine("Vuoi disdire altre prenotazioni? s/n");
        Console.ReadLine();
    }
    Console.WriteLine("Ok va bene!");

}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}
