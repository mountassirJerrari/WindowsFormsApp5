using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form2 : Form
    {
         string currentCmd;
        public Form2(string id_client , string id_commande  , DateTime dateCmd , string title)
        {
            InitializeComponent();
            Connection.insertCommande(id_client, id_commande , dateCmd);
            currentCmd = id_commande;
            gridViewsLoad();
            lblTitle.Font = new Font("Serif", 24);
            lblTitle.Text = title;
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        public void gridViewsLoad()
        {
            gvPlatAtt.DataSource = Connection.getAllPlat(currentCmd);
            gvPlats.DataSource = Connection.getAllPlat();
        }

        private void btnAddPlat_Click(object sender, EventArgs e)
        {

            string plat_id , qte;
            plat_id = gvPlats.SelectedCells[0].Value.ToString();
            qte = tbQte.Text;
            try
            {
                Connection.insertPlatCmd(currentCmd, plat_id, qte);
                lblError.Text = string.Empty;
                tbSearch.Text = string.Empty;
            }
            catch (Exception)
            {

                lblError.Text = "la quantité demandé est non disponible";
            }
            
            gridViewsLoad();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string search = tbSearch.Text;
            gvPlats.DataSource = Connection.findPlat(search);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
