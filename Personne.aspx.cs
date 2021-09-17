using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;

public partial class Personne : System.Web.UI.Page
{
    public static int id;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Dropstat.Items.Add("Medecin"); 
            Dropstat.Items.Add("Patient");
            Dropstat.Items.Add("Technicien");
            Dropstat.Items.Add("Utilisateur");
        }
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string statut = Dropstat.SelectedItem.ToString();

        if (statut == "Medecin") 
        {
            Lspecia.Visible = true;
            special.Visible = true;
            Lage.Visible = false;
            age.Visible = false;
            Lpoid.Visible = false;
            poid.Visible = false;
            Ltempe.Visible = false;
            tempe.Visible = false;
            Lprofi.Visible = false;
            Dropprof.Visible = false;
            Lpwd.Visible = false;
            pwd.Visible = false;
            Ltype.Visible = false;
            Droptype.Visible = false;
        }
        if (statut == "Patient")
        {
            Lspecia.Visible = false;
            special.Visible = false;
            Lage.Visible = true;
            age.Visible = true;
            Lpoid.Visible = true;
            poid.Visible = true;
            Ltempe.Visible = true;
            tempe.Visible = true;
            Lprofi.Visible = false;
            Dropprof.Visible = false;
            Lpwd.Visible = false;
            pwd.Visible = false;
            Ltype.Visible = false;
            Droptype.Visible = false;
        }
        if (statut == "Technicien")
        {
            Lspecia.Visible = false;
            special.Visible = false;
            Lage.Visible = false;
            age.Visible = false;
            Lpoid.Visible = false;
            poid.Visible = false;
            Ltempe.Visible = false;
            tempe.Visible = false;
            Lprofi.Visible = false;
            Dropprof.Visible = false;
            Lpwd.Visible = false;
            pwd.Visible = false;
            Ltype.Visible = true;
            Droptype.Visible = true;
        }
        if (statut == "Utilisateur")
        {
            Lspecia.Visible = false;
            special.Visible = false;
            Lage.Visible = false;
            age.Visible = false;
            Lpoid.Visible = false;
            poid.Visible = false;
            Ltempe.Visible = false;
            tempe.Visible = false;
            Lprofi.Visible = true;
            Dropprof.Visible = true;
            Lpwd.Visible = true;
            pwd.Visible = true;
            Ltype.Visible = false;
            Droptype.Visible = false;
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
         
        string statut = Dropstat.SelectedItem.ToString();
        string con = "Data Source=DESKTOP-65V7G18; initial catalog=hopital;  user id=delice; pwd=ikorineza; Integrated Security=true";
        SqlConnection k = new SqlConnection(con);
        k.Open();
        if (statut == "Medecin")
        {
            string per = "insert into Personne (nom,prenom,genre,statut) values('" + nom.Text + "','" + prenom.Text + "','" + Dropgenre.SelectedItem.ToString()+ "' ,'" + statut + "')";

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
            string med = "insert into Medecin(idMedecin,Specialite) values(" + id + ",'" + special.Text + "') ";
            perAdd = new SqlCommand(med, k);
            perAdd.ExecuteNonQuery();
            k.Close();
            Response.Write("<script> alert('enregistrement Reussir')</script>");
            Response.Redirect("Menu.aspx");
           
        }
        if (statut == "Patient")
        {
            string per = "insert into Personne (nom,prenom,genre,statut) values('" + nom.Text + "','" + prenom.Text + "','" + Dropgenre.SelectedItem.ToString() + "' ,'" + statut + "')";

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
            string patie = "insert into Patient(idPatient,temperature,poids,age) values(" + id + ",'" + tempe.Text + "','" + poid.Text +"','" + age.Text + "') ";
            perAdd = new SqlCommand(patie, k);
            perAdd.ExecuteNonQuery();
            k.Close();
            Response.Write("<script> alert('enregistrement Reussir')</script>");
            Response.Redirect("Menu.aspx");
        }
        if (statut == "Technicien")
        {
            string per = "insert into Personne (nom,prenom,genre,statut) values('" + nom.Text + "','" + prenom.Text + "','" + Dropgenre.SelectedItem.ToString() + "' ,'" + statut + "')";

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
            string tec = "insert into Technichien(idTechni,type) values(" + id + ",'" + Droptype.SelectedItem.ToString() + "') ";
            perAdd = new SqlCommand(tec, k);
            perAdd.ExecuteNonQuery();
            k.Close();
            Response.Write("<script> alert('enregistrement Reussir')</script>");
        }
        if (statut == "Utilisateur")
        {
            string per = "insert into Personne (nom,prenom,genre,statut) values('" + nom.Text + "','" + prenom.Text + "','" + Dropgenre.SelectedItem.ToString() + "' ,'Utilisat')";

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
            string user = "insert into Utilisateurs(idUtilisateur,profile,motpass) values(" + id + ",'" + Dropprof.SelectedItem.ToString() + "','" + pwd.Text + "') ";
            perAdd = new SqlCommand(user, k);
            perAdd.ExecuteNonQuery();
            k.Close();
            Response.Write("<script> alert('enregistrement Reussir')</script>");
        }
    }
    protected void Dropprof_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}