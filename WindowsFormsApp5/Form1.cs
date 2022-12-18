using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public string currentClient = "1";

        public Form1()
        {
            InitializeComponent();
            updateGridViews();


        }
        public void updateGridViews()
        {
            gvClient.DataSource = Connection.getAllClient();
            gvCommande.DataSource = Connection.getCommandes(currentClient);
            int last_cmd_id;
            int.TryParse(Connection.lastCmdid().Rows[0][0].ToString(), out last_cmd_id);
            tbCmdId.Text = (last_cmd_id + 1).ToString() ;
        }

        private void gvClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            currentClient = gvClient.SelectedCells[0].Value.ToString();
            gvCommande.DataSource = Connection.getCommandes(currentClient);
        }

        private void gvClient_SelectionChanged(object sender, EventArgs e)
        {

            try
            {
                currentClient = gvClient.SelectedCells[0].Value.ToString();
                gvCommande.DataSource = Connection.getCommandes(currentClient);
                loyalClientHighlight(currentClient);
            }
            catch (Exception)
            {
            }
           
        }

        private void btnAddCmd_Click(object sender, EventArgs e)
        {
            string title = "commande du client:" + gvClient.SelectedCells[1].Value.ToString();
            new Form2(currentClient ,tbCmdId.Text , dateCmd.Value , title).Show() ;
            
        }

        private void btnSuppCmd_Click(object sender, EventArgs e)
        {
            string commande = gvCommande.SelectedCells[0].Value.ToString();
            Connection.deleteCmdPlat(commande);
            Connection.deleteCmd(commande);
            updateGridViews();
        }
        public void loyalClientHighlight(string id_client)
        {
            
               
                foreach (DataRow row in Connection.allLoyalClients().Rows)
                {

                    if (row["id_client"].ToString() == id_client)
                    {
                    lblIsLoyal.Font = new Font("Serif",  24);
                    lblIsLoyal.Text = "✪";
                    break;
                    }else
                {
                    lblIsLoyal.Text = "";
                }
                }
               
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tbCmdId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
