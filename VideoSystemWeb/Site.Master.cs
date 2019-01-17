using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VideoSystemWeb.BLL;
using VideoSystemWeb.Entity;

namespace VideoSystemWeb
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           // lbl_benvenuto.Text = "Bentornato " + ((Anag_Utente)Session[SessionManager.UTENTE]).Nome + " " + ((Anag_Utente)Session[SessionManager.UTENTE]).Cognome;
        }
    }
}