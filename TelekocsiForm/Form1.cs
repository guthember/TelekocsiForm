using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelekocsiForm
{
  public partial class frmFo : Form
  {
    private List<Auto> autok = new List<Auto>();
    private List<Igeny> igenyek = new List<Igeny>();

    public frmFo()
    {
      InitializeComponent();
      lbKimenet.Items.Clear();
    }

    private void btnBeolvasas_Click(object sender, EventArgs e)
    {
      try
      {
        StreamReader a = new StreamReader("autok.csv");
        a.ReadLine();
        while (!a.EndOfStream)
        {
          string[] adat = a.ReadLine().Split(';');
          autok.Add(new Auto(adat[0], adat[1], adat[2], adat[3], Convert.ToInt32(adat[4])));
        }
        a.Close();

        StreamReader i = new StreamReader("igenyek.csv");
        i.ReadLine();
        while (!i.EndOfStream)
        {
          string[] adat = i.ReadLine().Split(';');
          igenyek.Add(new Igeny(adat[0], adat[1], adat[2], Convert.ToInt32(adat[3])));
        }
        i.Close();

        btnSecond.Enabled = true;
        btnBeolvasas.Enabled = false;
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void btnSecond_Click(object sender, EventArgs e)
    {
      lbKimenet.Items.Add("2. feladat");
      lbKimenet.Items.Add($"   {autok.Count} autós hirdet fuvart");
      btnSecond.Enabled = false;
      btnThird.Enabled = true;
    }

    private void btnThird_Click(object sender, EventArgs e)
    {
      lbKimenet.Items.Clear();

      lbKimenet.Items.Add("3. feladat");
      int ferohely = 0;
      foreach (var a in autok)
      {
        if (a.Utvonal == "Budapest-Miskolc")
        {
          ferohely += a.Ferohely;
        }
      }

      lbKimenet.Items.Add($"   Összesen {ferohely} férőhelyet hirdettek az autósok Budapestről Miskolcra");
      btnThird.Enabled = false;
      btnFourth.Enabled = true;
    }

    private void btnFourth_Click(object sender, EventArgs e)
    {
      int max = 0;
      string utv = "";

      var utvonalak = from a in autok
                      orderby a.Utvonal
                      group a by a.Utvonal into temp
                      select temp;

      foreach (var ut in utvonalak)
      {
        int fh = ut.Sum(x => x.Ferohely);
        if (max < fh)
        {
          max = fh;
          utv = ut.Key;
        }
      }

      lbKimenet.Items.Clear();
      lbKimenet.Items.Add("4. feladat");
      lbKimenet.Items.Add("A legtöb férőhelyet");
      lbKimenet.Items.Add($"({max})");
      lbKimenet.Items.Add("a");
      lbKimenet.Items.Add($"{utv} útvonalon");
      lbKimenet.Items.Add("ajánlották fel a hirdetők");

      btnFourth.Enabled = false;
      btnFifth.Enabled = true;
    }

    private void btnFifth_Click(object sender, EventArgs e)
    {
      lbKimenet.Items.Clear();
      lbKimenet.Items.Add("5. feladat");

      foreach (var igeny in igenyek)
      {
        int i = igeny.VanAuto(autok);

        if (i > -1)
        {
          lbKimenet.Items.Add($"{igeny.Azonosito}=>{autok[i].Rendszam}");
        }
      }

      btnFifth.Enabled = false;
      btnSixth.Enabled = true;
    }

    private void btnSixth_Click(object sender, EventArgs e)
    {
      try
      {
        lbKimenet.Items.Clear();
        lbKimenet.Items.Add("6. feladat");
        StreamWriter file = new StreamWriter("utasuzenetek.txt");

        foreach (var igeny in igenyek)
        {
          int i = igeny.VanAuto(autok);

          if (i > -1)
          {
            file.WriteLine($"{igeny.Azonosito}: Rendszám: {autok[i].Rendszam}, Telefonszám: {autok[i].Tel}");
          }
          else
          {
            file.WriteLine($"{igeny.Azonosito}: Sajnos nem sikerült autót találni");
          }
        }

        file.Close();
        lbKimenet.Items.Add("adatok fájlba írása megtörtént");
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void btnKilepes_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }
  }
}
