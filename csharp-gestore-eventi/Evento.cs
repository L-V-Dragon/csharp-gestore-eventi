using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_gestore_eventi
{
    public class Evento
    {
        private string titolo;
        DateTime data = new DateTime();
        private int capMax;
        private int nPrenotazioni;
        int postiPrenotati = 0;
        int postiDisdetti = 0;

        public Evento(string titolo, DateTime data, int capMax, int nPrenotazioni)
        {
            this.titolo = titolo;
            this.data = data;
            this.capMax = capMax;
            this.nPrenotazioni = 0;
        }

        public string GetTitolo()
        {
            return titolo;
        }

        public DateTime GetData()
        {
            return data;
        }

        public int GetCapMax()
        {
            return capMax;
        }

        public int GetNPrenotazioni()
        {
            return nPrenotazioni;
        }

        public void SetTitolo(string titolo)
        {
            titolo = this.titolo;
        }

        public void SetData(DateTime data)
        {
            data = this.data;
        }


        public void PrenotaPosti()
        {

            while (data < DateTime.Now)
            {
                throw new Exception("L'evento è già finito");
            }

            if (nPrenotazioni > capMax)
            {
                throw new Exception("Stai superando la capienza massima");
            }
            else if (nPrenotazioni < 0)
            {
                throw new Exception("Hai inserito un valore non valido");
            }
            else
            {
               postiPrenotati = nPrenotazioni;
            }
        }


        public void DisdiciPosti()
        {
           

            while (data < DateTime.Now)
            {
                throw new Exception("L'evento è già finito");
            }

            if (postiDisdetti > postiPrenotati)
            {
                throw new Exception("hai disdetto più posti di quelli prenotati");
            }
            else
            {
                postiPrenotati = nPrenotazioni - postiDisdetti;
            }

        }

        public override string ToString()
        {
            return this.data + this.titolo;
        }
    }
}
