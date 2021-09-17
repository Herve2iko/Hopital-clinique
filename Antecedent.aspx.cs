using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
//using Syncfusion.Pdf;

public partial class Antecedent : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
           
        }
    }
    protected void add_Click(object sender, EventArgs e)
    {
        string ch = "Data Source=DESKTOP-65V7G18; initial catalog=hopital;  user id=delice; pwd=ikorineza; Integrated Security=true";
        SqlConnection n = new SqlConnection(ch);
        n.Open();
        string re = ante.Text;
        if (re == "")
        {
            Response.Write("<script> alert('le champ est vide')</script>");
        }
        else
        {
            string antec = "insert into Anteceden (nomAntece) values('" + ante.Text + "')";
            SqlCommand antecAdd = new SqlCommand(antec, n);
            antecAdd.ExecuteNonQuery();
            n.Close();
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('saved successfully')", true);
            ante.Text = "";
            //LoadRecord();
        }
    }
  /*  void LoadRecord()
    {
        string ch = "Data Source=DESKTOP-65V7G18; initial catalog=hopital;  user id=delice; pwd=ikorineza; Integrated Security=true";
        SqlConnection n = new SqlConnection(ch);
        n.Open();
        string antec = "select * from Anteceden";
        SqlCommand antecAdd = new SqlCommand(antec, n);
        SqlDataAdapter d = new SqlDataAdapter(antecAdd);
        DataTable dt = new DataTable();
        d.Fill(dt);
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
    protected void rech_Click(object sender, EventArgs e)
    {
        LoadRecord();
    }*/
}