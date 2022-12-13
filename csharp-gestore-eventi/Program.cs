using csharp_gestore_eventi;


Console.WriteLine("Creiamo un Progarmma di eventi!");
Console.WriteLine();

Console.WriteLine("Dai un titolo al tuo programma");
string Titolo = Console.ReadLine();
ProgrammaEventi pEvent = new ProgrammaEventi(Titolo);
Console.WriteLine();

Console.WriteLine("Quanti eventi ci sono nel tuo programma?");
int nEventi = int.Parse(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Ora inseriamo i tuoi eventi");
Console.WriteLine();

while (pEvent.contaEventi() != nEventi)
{
    try
    {
        Console.WriteLine("Crea un evento");
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

        Evento eventoUtente = new Evento(titolo, data, capMax);
        eventoUtente.PrenotaPosti(nPrenotazioni);
        pEvent.aggiungiEvento(eventoUtente);
        Console.WriteLine(eventoUtente);
        Console.WriteLine("Capienza Massima Evento: " + eventoUtente.GetCapMax());
        Console.WriteLine("Numero Posti Prenotati: " + eventoUtente.GetNPrenotazioni());
        Console.WriteLine();

        Console.WriteLine("Vuoi disdire delle prenotazioni? s/n");

        while (Console.ReadLine() == "s")
        {
            Console.WriteLine();
            Console.WriteLine("Quanti prenotazioni vuoi disdire?");
            int postiDisdetti = int.Parse(Console.ReadLine());
            Console.WriteLine();

            eventoUtente.DisdiciPosti(postiDisdetti);
            Console.WriteLine(eventoUtente);
            Console.WriteLine("Capienza Massima Evento: " + eventoUtente.GetCapMax());
            Console.WriteLine("Numero Posti Prenotati: " + eventoUtente.GetNPrenotazioni());
            Console.WriteLine();

            Console.WriteLine("Vuoi disdire altre prenotazioni? s/n");
            Console.ReadLine();
        }

        Console.WriteLine();
        Console.WriteLine("Ok va bene!");
        Console.WriteLine();

    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
        Console.WriteLine();
    }
}
Console.WriteLine("Hai programmato " + pEvent.contaEventi() + " eventi");
Console.WriteLine("Gli eventi in programma sono: " + pEvent.ToString());
Console.WriteLine();

Console.WriteLine("Inserisci una data per vederne gli eventi (GG/MM/YYYY)");
string dataCheck = Console.ReadLine();
Console.WriteLine();

Console.WriteLine("Ecco gli eventi nella data richiesta");
Console.WriteLine(ProgrammaEventi.stampaLista(pEvent.eventoXData(dataCheck)));
pEvent.svuotaLista();
