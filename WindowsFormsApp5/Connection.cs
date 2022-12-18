using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp5
{

    internal class Connection
    {
        // connection variables : 
        static string chaine = @"Data Source=DESKTOP-CQ7KNB1\SQLEXPRESS;Initial Catalog=restau;Integrated Security=True";
        static SqlConnection cnx = new SqlConnection(chaine);
        static SqlCommand cmd = new SqlCommand();
        static SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        // end connection variables
        static public DataTable getAllClient()
        {
            cnx.Open();
            cmd.CommandText = "select * from client";
            cmd.Connection = cnx;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cnx.Close();
            return dt;

        }

        internal static DataTable getCommandes(string id_client)
        {
            cnx.Close();
            cnx.Open();
            cmd.CommandText = "select * from commande where  id_client ="+id_client;
            cmd.Connection = cnx;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cnx.Close();
            return dt;
        }
        static public  DataTable lastCmdid ()
        {
            cnx.Open();
            cmd.CommandText = "select max(id_commande)  from commande;";
            cmd.Connection = cnx;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cnx.Close();
            return dt;
        }

        internal static void insertCommande(string id_client, string id_commande ,DateTime date_cmd)
        {
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "insert into commande" +
                " values("+ id_commande + " ,'" + date_cmd.ToString("MM/dd/yyyy") + "'," + id_client+" , 0) ";
            cmd.ExecuteNonQuery();
            cnx.Close();

        }

        internal static object getAllPlat(string currentCmd)
        {
            cnx.Close();
            cnx.Open();
            cmd.CommandText = "select plat.id_plat , prix  , Nomp  , qtecmd from commande_plat , plat where plat.id_plat = commande_plat.id_plat and commande_plat.id_commande = "+ currentCmd + ";";
            cmd.Connection = cnx;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cnx.Close();
            return dt;
        }

        internal static object getAllPlat()
        {
            cnx.Open();
            cmd.CommandText = "select id_plat , prix  , Nomp , qteplat as QantiteDisponible   from  plat ;";
            cmd.Connection = cnx;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cnx.Close();
            return dt;
        }

        internal static void insertPlatCmd(string currentCmd, string plat_id , string qte)
        {
            
            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "insert into commande_plat" +
                " values(" + currentCmd + " ," + plat_id + " ," + qte + " ) ";
            cmd.ExecuteNonQuery();
            cnx.Close();
        }

        internal static void deleteCmdPlat(string commande_id)
        {

            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "delete from commande_plat where id_commande = "+ commande_id + " ";
            cmd.ExecuteNonQuery();
            cnx.Close();
        }

        internal static void deleteCmd(string commande_id)
        {

            cnx.Open();
            cmd.Connection = cnx;
            cmd.CommandText = "EXEC supp_commande @id_cmd = "+ commande_id + " ";
            cmd.ExecuteNonQuery();
            cnx.Close();
        }
        internal static DataTable allLoyalClients()
        {
            cnx.Open();
            cmd.CommandText = "select * from  all_loyal_client();";
            cmd.Connection = cnx;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cnx.Close();
            return dt;
        }

        internal static object findPlat(string search)
        {
            cnx.Close();
            cnx.Open();
            cmd.CommandText = "select plat.id_plat , prix  , Nomp  ,qteplat as QantiteDisponible from  plat where nomP LIKE  '" + search + "%'";
            cmd.Connection = cnx;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cnx.Close();
            return dt;
        }
    }
}
