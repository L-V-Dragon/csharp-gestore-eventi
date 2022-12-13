using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_gestore_eventi
{
    public class ProgrammaEventi
    {
        private string Titolo;
        private List<Evento> eventi;

        public ProgrammaEventi(string Titolo)
        {
            this.Titolo = Titolo;
            this.eventi = new List<Evento>();   
        }

        public string GetTitolo()
        {
            return Titolo;
        }

        public void SetTitolo(string Titolo)
        {
            Titolo = this.Titolo;
        }

        public void aggiungiEvento(Evento evento)
        {
            eventi.Add(evento);
        }

        public List<Evento> eventoXData(string data)
        {
            List<Evento> eventiXData = new List<Evento>(); 
            foreach (Evento evento in eventi)
            {
                if (evento.GetData().ToString() == data)
                {
                    eventiXData.Add(evento);
                }
            }
            return eventiXData;
        }

        public static string stampaLista(List<Evento> eventi)
        {
            return eventi.ToString();
        }

        public int contaEventi()
        {
            return eventi.Count();
        }

        public void svuotaLista()
        {
            eventi.Clear();
        }

        public override string ToString()
        {
            string programma = this.GetTitolo();
            programma += ProgrammaEventi.stampaLista(this.eventi);
            return programma;
        }
    }
}
