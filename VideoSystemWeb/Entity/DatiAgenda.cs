﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VideoSystemWeb.Entity
{
    public class DatiAgenda
    {
        public int id;
        public int id_risorsa;
        public DateTime data_inizio;
        public DateTime data_fine;
        public string descrizione;

        public DatiAgenda(int id, int id_risorsa, DateTime data_inizio, DateTime data_fine, string descrizione)
        {
            this.id = id;
            this.id_risorsa = id_risorsa;
            this.data_inizio = data_inizio;
            this.data_fine = data_fine;
            this.descrizione = descrizione;
        }
    }
}