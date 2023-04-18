using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Net.WebRequestMethods;
using File = System.IO.File;

namespace CRUD_27
{
    public partial class Form1 : Form
    {
        #region declare
        public struct Prodotto
        {
            public string n;
            public float pr;
        }
        public Prodotto[] p;
        public static int d;
        string f,l;
        public Form1()
        {
            InitializeComponent();
            p=new Prodotto[100];
            d = 0;
            f = "@file.csv";
            if (!File.Exists(f))
            {
                File.Create(f);
            }
            vis(f);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #endregion
        #region pulsanti

        private void Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Price_TextChanged(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            p[d].n = Name.Text;
            p[d].pr = float.Parse(Price.Text);
            scriviAppend(ToString(p, d), f);
            d++;
        }

        private void delete_Click(object sender, EventArgs e)
        {

        }

        private void rese_Click(object sender, EventArgs e)
        {

        }

        private void mod_Click(object sender, EventArgs e)
        {

        }

        private void price2_TextChanged(object sender, EventArgs e)
        {

        }

        private void nnome_TextChanged(object sender, EventArgs e)
        {

        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void del_Click(object sender, EventArgs e)
        {
            File.Delete(f);
            Console.Clear();
        }
        #endregion
        #region funzioni
        public static string ToString(Prodotto[] p, int d)
        {
            string sep = ";";
            return (p[d].n + sep + p[d].pr);

        }
        public static void scriviAppend(string l, string f)
        {
            var oStream = new FileStream(f, FileMode.Append, FileAccess.Write, FileShare.Read);
            StreamWriter sw = new StreamWriter(oStream);
            sw.WriteLine(l);
            sw.Close();
        }
        public static int cercaSuFile(string f, string input, ref int l)
        {
            StreamReader sr = new StreamReader(f);
            string linea = "";
            l = 0;

            while (!sr.EndOfStream)
            {
                linea = sr.ReadLine();
                String[] split = linea.Split(';');

                if (split[0] == input)
                {
                    break;
                }
                l++;
            }

            sr.Close();

            return l;
        }
        public void vis(string f)
        {
            using (StreamReader sr = File.OpenText(f))
            {
                string s;
                listView1.View = View.Details;
                listView1.Columns.Add("Nome", 108, HorizontalAlignment.Left);
                listView1.Columns.Add("Prezzo", 108, HorizontalAlignment.Left);
                listView1.Columns.Add("Quantità", 104, HorizontalAlignment.Left);
                listView1.GridLines = true;
                while (!sr.EndOfStream)
                {
                    s = sr.ReadLine();
                    string[] dati = s.Split(';');
                    if (dati[3] == "0")
                    {
                        float price = float.Parse(dati[1]);
                        ListViewItem newItem = new ListViewItem();
                        newItem.Text = dati[0];
                        newItem.SubItems.Add(price.ToString("0.00") + "€");
                        newItem.SubItems.Add(dati[2]);
                        listView1.Items.Add(newItem);
                    }
                }
                sr.Close();
            }
        }


        #endregion

        
    }
}
