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

namespace CRUD_27
{
    public partial class Form1 : Form
    {
        #region declare
        public struct Prodotto
        {
            public string n;
            public string pr;
        }
        public static Prodotto[] p;
        public static int d;
        public Form1()
        {
            InitializeComponent();
            p=new Prodotto[100];
            d = 0;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion
        #region funzioni
        public static string ToString(Prodotto p, string sep = ";")
        {

            return (p.n + sep + p.pr);

        }
        public static void AggiungiSuFile(Prodotto p, string filename)
        {
            scriviAppend(ToString(p), filename);
        }
        public static void scriviAppend(string content, string filename)
        {
            var oStream = new FileStream(filename, FileMode.Append, FileAccess.Write, FileShare.Read);
            StreamWriter sw = new StreamWriter(oStream);
            sw.WriteLine(content);
            sw.Close();
        }

        #endregion
    }
}
