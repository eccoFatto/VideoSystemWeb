using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VideoSystemWeb.Entity
{
    public static class Tipologie
    {
        #region TIPI EVENTO
        public static Tipo_Evento EVENTO_VIAGGIO = new Tipo_Evento() { id = 1, titolo = "Viaggio/installazione", descrizione = "Tipologia di evento n.1", colore = "#FFCC00" };
        public static Tipo_Evento EVENTO_PREVISIONE = new Tipo_Evento() { id = 2, titolo = "Previsione impegni", descrizione = "Tipologia di evento n.2", colore = "grey" };
        public static Tipo_Evento EVENTO_OFFERTE = new Tipo_Evento() { id = 3, titolo = "Offerte", descrizione = "Tipologia di evento n.3", colore = "green" };
        public static Tipo_Evento EVENTO_LAVORAZIONI = new Tipo_Evento() { id = 4, titolo = "Lavorazioni", descrizione = "Tipologia di evento n.4", colore = "blue" };
        public static Tipo_Evento EVENTO_RIPOSI = new Tipo_Evento() { id = 5, titolo = "Riposi", descrizione = "Tipologia di evento n.5", colore = "#E85C00" };
        #endregion

        #region TIPI UTENTE
        public static Tipo_Utente TIPO_AMMINISTRATORE = new Tipo_Utente() { id = 1, tipoUtente= "Amministartore", descrizione = "Amministratore" };
        public static Tipo_Utente TIPO_OPERATORE = new Tipo_Utente() { id = 2, tipoUtente = "Operatore", descrizione = "Operatore" };
        public static Tipo_Utente TIPO_VISUALIZZATORE = new Tipo_Utente() { id = 2, tipoUtente = "Visualizzatore", descrizione = "Visualizzatore" };
        #endregion

        
    }
}