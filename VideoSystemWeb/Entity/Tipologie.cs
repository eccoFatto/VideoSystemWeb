﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VideoSystemWeb.Entity
{
    public static class Tipologie
    {
        #region TIPI EVENTO
        //public static Tipo_Evento EVENTO_VIAGGIO = new Tipo_Evento() { id = 1, titolo = "Viaggio/installazione", descrizione = "Tipologia di evento n.1", colore = "#FFCC00" };
        //public static Tipo_Evento EVENTO_PREVISIONE = new Tipo_Evento() { id = 2, titolo = "Previsione impegni", descrizione = "Tipologia di evento n.2", colore = "grey" };
        //public static Tipo_Evento EVENTO_OFFERTE = new Tipo_Evento() { id = 3, titolo = "Offerte", descrizione = "Tipologia di evento n.3", colore = "green" };
        //public static Tipo_Evento EVENTO_LAVORAZIONI = new Tipo_Evento() { id = 4, titolo = "Lavorazioni", descrizione = "Tipologia di evento n.4", colore = "blue" };
        //public static Tipo_Evento EVENTO_RIPOSI = new Tipo_Evento() { id = 5, titolo = "Riposi", descrizione = "Tipologia di evento n.5", colore = "#E85C00" };
        #endregion

        #region TIPI UTENTE
        public static Tipo_Utente TIPO_AMMINISTRATORE = new Tipo_Utente() { id = 1, tipoUtente= "Amministartore", descrizione = "Amministratore" };
        public static Tipo_Utente TIPO_OPERATORE = new Tipo_Utente() { id = 2, tipoUtente = "Operatore", descrizione = "Operatore" };
        public static Tipo_Utente TIPO_VISUALIZZATORE = new Tipo_Utente() { id = 2, tipoUtente = "Visualizzatore", descrizione = "Visualizzatore" };
        #endregion

        #region COLONNE_AGENDA (Risorse)
        public static List<Tipologica> getListaRisorse()
        {
            List<Tipologica> listaRisorse = new List<Tipologica>();

            listaRisorse.Add(new Tipologica(1, "Mirco", "Mirco Rossi", "dipendenti", "COLOR=RED"));
            listaRisorse.Add(new Tipologica(2, "Toti", "Enrico Toti", "dipendenti", "COLOR=RED"));
            listaRisorse.Add(new Tipologica(3, "Costa", "Costantino Marroni", "dipendenti", "COLOR=RED"));
            listaRisorse.Add(new Tipologica(4, "Daniele", "Daniele Verdi", "dipendenti", "COLOR=RED"));
            listaRisorse.Add(new Tipologica(6, "Nicola", "Nicola Rossi", "dipendenti", "COLOR=RED"));
            listaRisorse.Add(new Tipologica(7, "Regia 1", "Regia 1", "regie", "COLOR=GREEN"));
            listaRisorse.Add(new Tipologica(8, "Regia 2", "Regia 2", "regie", "COLOR=GREEN"));
            listaRisorse.Add(new Tipologica(9, "Regia 3", "Regia 3", "regie", "COLOR=GREEN"));
            listaRisorse.Add(new Tipologica(10, "Extra 1", "Extra 1", "extra", "COLOR=BLUE"));
            listaRisorse.Add(new Tipologica(11, "Extra 2", "Extra 2", "extra", "COLOR=BLUE"));
            listaRisorse.Add(new Tipologica(12, "Extra 3", "Extra 3", "extra", "COLOR=BLUE"));
            listaRisorse.Add(new Tipologica(13, "Extra 4", "Extra 4", "extra", "COLOR=BLUE"));
            listaRisorse.Add(new Tipologica(14, "Extra 5", "Extra 5", "extra", "COLOR=BLUE"));
            listaRisorse.Add(new Tipologica(15, "Extra 6", "Extra 6", "extra", "COLOR=BLUE"));

            return listaRisorse;
        }

        public static Tipologica getTipologicaById(int id)
        {
            return getListaRisorse().Where(x => x.id == id).FirstOrDefault();
        }
        #endregion

        #region DATI AGENDA
        public static List<DatiAgenda> getListaDatiAgenda()
        {
            List<DatiAgenda> listaDatiAgenda = new List<DatiAgenda>();

            listaDatiAgenda.Add(new DatiAgenda(1, 1, new DateTime(2019, 1, 16), new DateTime(2019, 1, 18), "Ev 1"));
            listaDatiAgenda.Add(new DatiAgenda(2, 1, new DateTime(2019, 1, 21), new DateTime(2019, 1, 22), "Ev 2"));
            listaDatiAgenda.Add(new DatiAgenda(3, 1, new DateTime(2019, 1, 25), new DateTime(2019, 1, 27), "Ev 3"));

            listaDatiAgenda.Add(new DatiAgenda(4, 3, new DateTime(2019, 1, 17), new DateTime(2019, 1, 20), "Ev 4"));
            listaDatiAgenda.Add(new DatiAgenda(5, 3, new DateTime(2019, 1, 22), new DateTime(2019, 1, 22), "Ev 5"));
            listaDatiAgenda.Add(new DatiAgenda(6, 3, new DateTime(2019, 1, 24), new DateTime(2019, 1, 27), "Ev 6"));

            listaDatiAgenda.Add(new DatiAgenda(7, 4, new DateTime(2019, 1, 19), new DateTime(2019, 1, 20), "Ev 7"));
            listaDatiAgenda.Add(new DatiAgenda(8, 4, new DateTime(2019, 1, 23), new DateTime(2019, 1, 24), "Ev 8"));

            listaDatiAgenda.Add(new DatiAgenda(9, 6, new DateTime(2019, 1, 16), new DateTime(2019, 1, 20), "Ev 9"));
            listaDatiAgenda.Add(new DatiAgenda(10, 6, new DateTime(2019, 1, 22), new DateTime(2019, 1, 22), "Ev 10"));
            listaDatiAgenda.Add(new DatiAgenda(11, 6, new DateTime(2019, 1, 24), new DateTime(2019, 1, 24), "Ev 11"));
            listaDatiAgenda.Add(new DatiAgenda(12, 6, new DateTime(2019, 1, 26), new DateTime(2019, 1, 26), "Ev 12"));
            return listaDatiAgenda;

        }
        #endregion
    }
}