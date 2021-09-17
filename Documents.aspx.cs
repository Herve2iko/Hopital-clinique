using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
using sharpPDF;

public partial class Documents : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        string ch = "Data Source=DESKTOP-65V7G18; initial catalog=hopital;  user id=delice; pwd=ikorineza; Integrated Security=true";
        SqlConnection n = new SqlConnection(ch);
        n.Open();
        if (!IsPostBack)
        {
            Label2.Visible = false;
            Label1.Visible = false;
            patient.Visible = false;
            medecin.Visible = false;
            Button1.Visible = false;
            Button2.Visible = false;
            Label5.Visible = false;
            service.Visible = false;
            
            patient.Items.Add("select patient");
            medecin.Items.Add("select Medecin");


            string req = "select p.idpatient,h.nom,h.prenom from Patient p,Personne h where p.idpatient = h.idPersonne";
            SqlCommand com = new SqlCommand(req, n);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                patient.Items.Add(dr.GetInt32(0) + "  " + dr.GetString(1) + "  " + dr.GetString(2));
            }
            n.Close();
            n.Open();
            req = "select p.idMedecin,h.nom,h.prenom from Medecin p,Personne h where p.idMedecin = h.idPersonne";
            com = new SqlCommand(req, n);
            dr = com.ExecuteReader();
            while (dr.Read())
            {
                medecin.Items.Add(dr.GetInt32(0) + "  " + dr.GetString(1) + "  " + dr.GetString(2));
            }
            n.Close();
            n.Open();


            string requete = "Select * from Service";
            SqlCommand com1 = new SqlCommand(requete, n);

            SqlDataReader dr1 = com1.ExecuteReader();
            while (dr1.Read())
            {
                service.Items.Add(dr1.GetInt32(0) + " " + dr1.GetString(1));

            }
            n.Close();
        }
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string statut = DropDownList1.SelectedItem.ToString();
        if (statut == "Ordonnance")
        {
            Label2.Visible = true;
            Label1.Visible = true;
            patient.Visible = true;
            medecin.Visible = true;
            service.Visible = false;
            Label5.Visible = false;
            Button1.Visible = true;
            Button2.Visible = false;

        }
        if (statut == "Rapport")
        {
            Label2.Visible = true;
            Label1.Visible = false;
            patient.Visible = true;
            medecin.Visible = false;
            Button1.Visible = false;
            Button2.Visible = true;
            Label5.Visible = true;
            service.Visible = true;


        }


    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string ch = "Data Source=DESKTOP-65V7G18; initial catalog=hopital;  user id=delice; pwd=ikorineza; Integrated Security=true";
        SqlConnection n = new SqlConnection(ch);
        n.Open();
        string med = patient.SelectedItem.ToString();
        string ser = medecin.SelectedItem.ToString();
        string[] paTab = med.Split(' ');
        string[] serTab = ser.Split(' ');

        DateTime date = DateTime.Now;
        pdfDocument d = new pdfDocument("Ordonnence", "ikorineza");
        pdfPage p = d.addPage();
        //p.addImage(,200,400,150,300);
        p.addText("Nom et Prenom", 20, 760, d.getFontReference(sharpPDF.Enumerators.predefinedFont.csCourierBoldOblique), 14);
        p.addText("Genre :", 20, 720, d.getFontReference(sharpPDF.Enumerators.predefinedFont.csCourierBoldOblique), 14);
        p.addText("Poids :", 20, 700, d.getFontReference(sharpPDF.Enumerators.predefinedFont.csCourierBoldOblique), 14);
        p.addText("Temperature :", 20, 680, d.getFontReference(sharpPDF.Enumerators.predefinedFont.csCourierBoldOblique), 14);

        p.addText(med, 180, 760, d.getFontReference(sharpPDF.Enumerators.predefinedFont.csCourierBoldOblique), 14);

        p.addText("Ordonnance Medicale", 180, 660, d.getFontReference(sharpPDF.Enumerators.predefinedFont.csCourierBoldOblique), 14);


        p.addText("Medecin General", 450, 100, d.getFontReference(sharpPDF.Enumerators.predefinedFont.csCourierBoldOblique), 14);
        p.addText(serTab[1]+serTab[2], 400, 80, d.getFontReference(sharpPDF.Enumerators.predefinedFont.csCourierBoldOblique), 14);


        
        d.createPDF(@"C:\Users\HERVE 2IKO\Desktop\auth\ordonance.pdf");

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        string ser = service.SelectedItem.ToString();
        string[] tser = ser.Split(' ');
        string ch = "Data Source=DESKTOP-65V7G18; initial catalog=hopital;  user id=delice; pwd=ikorineza; Integrated Security=true";

        SqlConnection n = new SqlConnection(ch);

        n.Open();


        pdfDocument d = new pdfDocument("Rapport", "christa");
        pdfPage p = d.addPage();
        //p.addImage(,200,400,150,300);
        p.addText("les patient consulte dans le service de " + tser[1] + " ", 20, 750, d.getFontReference(sharpPDF.Enumerators.predefinedFont.csCourierBoldOblique), 14);



        string requete = "Select personne.nom,personne.prenom, personne.genre,Patient.age,Patient.poids,Patient.temperature from Patient,Personne,consultation where Personne.idPersonne= Patient.idPatient and consultation.patient = patient.idpatient and consultation.service=" + tser[0] + "";
        SqlCommand com1 = new SqlCommand(requete, n);

        SqlDataReader dr = com1.ExecuteReader();

        p.addText("Nom ", 20, 720, d.getFontReference(sharpPDF.Enumerators.predefinedFont.csCourierBoldOblique), 14);
        p.addText("Prenom ", 90, 720, d.getFontReference(sharpPDF.Enumerators.predefinedFont.csCourierBoldOblique), 14);
        p.addText("Genre", 160, 720, d.getFontReference(sharpPDF.Enumerators.predefinedFont.csCourierBoldOblique), 14);
        p.addText("age", 220, 720, d.getFontReference(sharpPDF.Enumerators.predefinedFont.csCourierBoldOblique), 14);
        p.addText("Poids", 280, 720, d.getFontReference(sharpPDF.Enumerators.predefinedFont.csCourierBoldOblique), 14);
        p.addText("Temperature", 340, 720, d.getFontReference(sharpPDF.Enumerators.predefinedFont.csCourierBoldOblique), 14);

        while (dr.Read())
        {
            p.addText(dr.GetString(0), 20, 700, d.getFontReference(sharpPDF.Enumerators.predefinedFont.csCourierBoldOblique), 14);
            p.addText(dr.GetString(1), 90, 700, d.getFontReference(sharpPDF.Enumerators.predefinedFont.csCourierBoldOblique), 14);
            p.addText(dr.GetString(2), 170, 700, d.getFontReference(sharpPDF.Enumerators.predefinedFont.csCourierBoldOblique), 14);
            p.addText(dr.GetInt32(3).ToString(), 240, 700, d.getFontReference(sharpPDF.Enumerators.predefinedFont.csCourierBoldOblique), 14);
            p.addText(dr.GetString(4), 280, 700, d.getFontReference(sharpPDF.Enumerators.predefinedFont.csCourierBoldOblique), 14);
            p.addText(dr.GetString(5), 340, 700, d.getFontReference(sharpPDF.Enumerators.predefinedFont.csCourierBoldOblique), 14);

        }

        d.createPDF(@"C:\Users\HERVE 2IKO\Desktop\auth\rapport.pdf");

    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}