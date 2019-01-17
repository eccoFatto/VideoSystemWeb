using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VideoSystemWeb.Entity;

namespace VideoSystemWeb
{
    public partial class grigliaNicola : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            gv_scheduler.DataSource = CreateDataTable(new DateTime(2019, 1, 1));
            gv_scheduler.DataBind();
        }

        private DataTable CreateDataTable(DateTime data)
        {
            List<DatiAgenda> listaDatiAgenda = Tipologie.getListaDatiAgenda();
            List<Tipologica> listaRisorse = Tipologie.getListaRisorse();

            DataTable table = new DataTable();

            #region intestazione tabella
            DataColumn column;
            column = new DataColumn();
            column.DataType = typeof(string);
            column.ColumnName = " ";
            table.Columns.Add(column);

            foreach (Tipologica risorsa in listaRisorse)
            {
                column = new DataColumn();
                column.DataType = typeof(string);
                column.ColumnName = risorsa.nome;

                table.Columns.Add(column);
            }
            #endregion

            #region dati agenda
            for (int indiceRiga = 0; indiceRiga < 31; indiceRiga++)
            {
                DataRow row = table.NewRow();
                DateTime dataRiga = data.AddDays(indiceRiga);
                row[0] = dataRiga.ToString("dd/MM/yyyy");

                int indiceColonna = 1;
                foreach (Tipologica risorsa in listaRisorse)
                {
                    row[indiceColonna++] = listaDatiAgenda.Where(x => x.data_inizio <= dataRiga && x.data_fine >= dataRiga && x.id_risorsa == risorsa.id).Count() > 0 ? "X" : " ";

                }
                table.Rows.Add(row);
            }
            #endregion
            
            return table;
        }

        protected void gv_scheduler_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.Header)
            {
                e.Row.Attributes.Add("style", "background-color:yellowgreen;font-size:10pt;text-align:center;");
            }

            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Cells[0].Attributes.Add("style", "font-weight:bold;background-color:yellowgreen;");
                e.Row.Attributes.Add("style", "text-align:center;");
            }
        }

       

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            gv_scheduler.DataSource = CreateDataTable(DateTime.Parse(TextBox1.Text));
            gv_scheduler.DataBind();
        }
       

    }
}