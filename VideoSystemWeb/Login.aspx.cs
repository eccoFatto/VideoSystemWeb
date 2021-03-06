﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;
using VideoSystemWeb.BLL;
using VideoSystemWeb.Entity;

namespace VideoSystemWeb
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
                Session["connectionString"] = constr;
                Session["utenteAttivo"] = null;
            }
        }

        protected void btnLogIn_Click(object sender, EventArgs e)
        {
            string constr = Session["connectionString"].ToString();

            if (Convert.ToBoolean(ConfigurationManager.AppSettings["USA_DB"]))
            {
                using (MySqlConnection con = new MySqlConnection(constr))
                {
                    using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM anag_utenti where username = '" + tbUser.Text.Trim() + "' and password = '" + tbPassword.Text.Trim() + "'"))
                    {
                        using (MySqlDataAdapter sda = new MySqlDataAdapter())
                        {
                            cmd.Connection = con;
                            sda.SelectCommand = cmd;
                            using (DataTable dt = new DataTable())
                            {
                                sda.Fill(dt);
                                //GridView1.DataSource = dt;
                                //GridView1.DataBind();
                                if (dt != null && dt.Rows != null && dt.Rows.Count == 1)
                                {
                                    //Anag_Utente utenteConnesso = new Anag_Utente();
                                    //utenteConnesso.Nome = dt.Rows[0]["Nome"].ToString();
                                    //utenteConnesso.Cognome = dt.Rows[0]["Cognome"].ToString();
                                    //utenteConnesso.Descrizione = dt.Rows[0]["Descrizione"].ToString();
                                    //utenteConnesso. = dt.Rows[0]["Nome"].ToString();

                                    Session[SessionManager.UTENTE] = dt.Rows[0];
                                    Response.Redirect("Agenda.aspx", true);

                                }
                            } 
                        }
                    }
                }
            }
            else
            {
                //DataTable dtUtenti = new DataTable();
                //dtUtenti.Columns.Add("Cognome");
                //dtUtenti.Columns.Add("Nome");

                //DataRow utenteAttivo = dtUtenti.NewRow();
                //utenteAttivo["Cognome"] = "Foti";
                //utenteAttivo["Nome"] = "Nicola";

                //Session["utenteAttivo"] = utenteAttivo;

                Session[SessionManager.UTENTE] = new Anag_Utente() { id = 1, Nome = "Sandro", Cognome = "Chiappa", tipo = Tipologie.TIPO_OPERATORE };
                Response.Redirect("Agenda.aspx", true);
            }

            

        }
    }
}