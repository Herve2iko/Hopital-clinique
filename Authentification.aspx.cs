using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
public partial class Authentification : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string ch = "Data Source=DESKTOP-65V7G18; initial catalog=hopital;  user id=delice; pwd=ikorineza; Integrated Security=true";
        SqlConnection n = new SqlConnection(ch);
        n.Open();

        string req = "select * from Utilisateurs where idUtilisateur = '" + id.Text + "' and motpass='" + pwd.Text + "'";
        SqlCommand com = new SqlCommand(req, n);
        SqlDataReader dr = com.ExecuteReader();
        if (dr.Read())
        {
            Response.Redirect("Menu.aspx");
        }

    }
}