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
        DateTime data;
        private int capMax;
        private int nPrenotazioni;
        
        

        public Evento(string titolo, string data, int capMax)
        {
            SetTitolo(titolo);
            SetData(data);
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
            this.titolo = titolo;
        }

        public void SetData(string data)
        {
            this.data = DateTime.Parse(data);
        }


        public void PrenotaPosti(int postiPrenotati)
        {

            if (data < DateTime.Today)
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
               nPrenotazioni += postiPrenotati;
            }
        }


        public void DisdiciPosti(int postiDisdetti)
        {
           

            if (data < DateTime.Today)
            {
                throw new Exception("L'evento è già finito");
            }

            if ( nPrenotazioni - postiDisdetti < 0)
            {
                throw new Exception("hai disdetto più posti di quelli prenotati");
            }
            else
            {
                nPrenotazioni -= postiDisdetti;
            }

        }

        public override string ToString()
        {
            return this.GetData().ToString("dd/MM/yyyy") + " - " + this.GetTitolo();
        }
    }
}
