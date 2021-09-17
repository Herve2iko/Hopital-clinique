using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;

public partial class Morgue : System.Web.UI.Page
{
    public static int id;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string con = "Data Source=DESKTOP-65V7G18; initial catalog=hopital;  user id=delice; pwd=ikorineza; Integrated Security=true";
        SqlConnection k = new SqlConnection(con);
        k.Open();
        string per = "insert into Personne (nom,prenom,genre,statut) values('" + nom.Text + "','" + prenom.Text + "','" + Dropgenre.SelectedItem.ToString() + "' ,' Décé ')";

        SqlCommand perAdd = new SqlCommand(per, k);
        perAdd.ExecuteNonQuery();
        k.Close();
        k.Open();
        string persAct = "select max(idPersonne) as 'id' from Personne";
        perAdd = new SqlCommand(persAct, k);
        SqlDataReader dr = perAdd.ExecuteReader();
        if (dr.HasRows)
        {
            while (dr.Read())
            {
                id = dr.GetInt32(0);
            }
        }
        k.Close();
        k.Open();
        string med = "insert into Morgue(idDece,cause) values(" + id + ",'" + cause.Text + "') ";
        perAdd = new SqlCommand(med, k);
        perAdd.ExecuteNonQuery();
        k.Close();
        Response.Write("<script> alert('enregistrement Reussir')</script>");
        Response.Redirect("Menu.aspx");
    }
}