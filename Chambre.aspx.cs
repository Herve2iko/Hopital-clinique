using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;

public partial class Chambre : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string ch = "Data Source=DESKTOP-65V7G18; initial catalog=hopital;  user id=delice; pwd=ikorineza; Integrated Security=true";
        SqlConnection n = new SqlConnection(ch);
        n.Open();
        string nu = num.Text;
        string bl = bloc.Text;
        string li = lit.Text;

        if (nu == "" || bl == "" || li == "")
        {
            Response.Write("<script> alert('certains champs sont vides')</script>");
        }
        else
        {
            string ser = "insert into Chambre (numero,bloc,nombreLit) values('" + num.Text + "','" + bloc.Text + "','" + lit.Text + "')";
            SqlCommand serAdd = new SqlCommand(ser, n);
            serAdd.ExecuteNonQuery();
            n.Close();
            Response.Write("<script> alert('enregistrement Reussir')</script>");
        }
    }
}