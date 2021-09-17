using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
public partial class Examen : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string ch = "Data Source=DESKTOP-65V7G18; initial catalog=hopital;  user id=delice; pwd=ikorineza; Integrated Security=true";
        SqlConnection n = new SqlConnection(ch);
        n.Open();
        if (!IsPostBack) {
            DropDownList1.Items.Add("select patient");
            DropDownList2.Items.Add("select labo");
            DropDownList2.Items.Add("Laboratoire");
            DropDownList2.Items.Add("Radiographie");
            DropDownList3.Items.Add("select laboratin");


            string req = "select p.idpatient,h.nom,h.prenom from Patient p,Personne h where p.idpatient = h.idPersonne";
            SqlCommand com = new SqlCommand(req, n);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                DropDownList1.Items.Add(dr.GetInt32(0) + "  " + dr.GetString(1) + "  " + dr.GetString(2));
            }
            n.Close();
            n.Open();
            req = "select p.idTechni,h.nom,h.prenom from Technichien p,Personne h where p.idTechni = h.idPersonne";
            com = new SqlCommand(req, n);
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                DropDownList3.Items.Add(dr.GetInt32(0) + "  " + dr.GetString(1) +" "+dr.GetString(2));
            }
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string ch = "Data Source=DESKTOP-65V7G18; initial catalog=hopital;  user id=delice; pwd=ikorineza; Integrated Security=true";
        SqlConnection n = new SqlConnection(ch);
        n.Open();
        string pat = DropDownList1.SelectedItem.ToString();
        string lab = DropDownList2.SelectedItem.ToString();
        string tec = DropDownList3.SelectedItem.ToString();
        string[] patTab = pat.Split(' ');

        string[] tecTab = tec.Split(' ');

        DateTime date = DateTime.Now;
        string serv = "insert into AnalyseExamen (patient,labo,technicien,result) values(" + patTab[0] + ",'" + lab + "'," + tecTab[0] + ",'" + result.Text + "')";
        SqlCommand serAdd = new SqlCommand(serv, n);
        serAdd.ExecuteNonQuery();
        n.Close();
        Response.Write("<script> alert('enregistrement Reussir')</script>");
    }
}