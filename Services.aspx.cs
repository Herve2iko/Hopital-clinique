using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;

public partial class Services : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void add_Click(object sender, EventArgs e)
    {
        string ch = "Data Source=DESKTOP-65V7G18; initial catalog=hopital;  user id=delice; pwd=ikorineza; Integrated Security=true";
        SqlConnection n = new SqlConnection(ch);
        n.Open();
        string re = nom.Text;
        if (re == "")
        {
            Response.Write("<script> alert('le champ est vide')</script>");
        }
        else
        {
            string ser = "insert into Service (nomService) values('" + nom.Text + "')";
            SqlCommand serAdd = new SqlCommand(ser, n);
            serAdd.ExecuteNonQuery();
            n.Close();
            Response.Write("<script> alert('enregistrement Reussir')</script>");
        }
    }
}