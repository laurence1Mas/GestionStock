﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_stock.classes
{
    class MYCONNEXION
    {
        SqlConnection con;
        //SqlDataReader dr;
        public static SqlDataAdapter dt = null;
        public static DataSet ds = new DataSet();

        //==========================METHODE D'IMPRESSION D'UNE LISTE=============
        public DataSet getAchatsEntreDates(DateTime dateDebut, DateTime dateFin, string nomTable)
        {
            con = new dataconnexion().DBConnect();
            DataSet dst = new DataSet();
            try
            {
                if (!con.State.ToString().ToLower().Equals("open")) con.Open();

                // Préparer la commande pour exécuter la procédure stockée
                SqlCommand cmd = new SqlCommand("GetAchatsEntreDates", con);
                cmd.CommandType = CommandType.StoredProcedure;

                // Ajouter les paramètres de date
                cmd.Parameters.Add(new SqlParameter("@DateDebut", dateDebut));
                cmd.Parameters.Add(new SqlParameter("@DateFin", dateFin));

                dt = new SqlDataAdapter(cmd);

                // Remplir le DataSet avec le résultat de la procédure
                dt.Fill(dst, nomTable);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dt.Dispose();
                con.Close();
            }

            return dst;
        }

        public DataSet getVentesEntreDates(DateTime dateDebut, DateTime dateFin, string nomTable)
        {
            con = new dataconnexion().DBConnect();
            DataSet dst = new DataSet();
            try
            {
                if (!con.State.ToString().ToLower().Equals("open")) con.Open();

                // Préparer la commande pour exécuter la procédure stockée
                SqlCommand cmd = new SqlCommand("GetVentesEntreDates", con);
                cmd.CommandType = CommandType.StoredProcedure;

                // Ajouter les paramètres de date
                cmd.Parameters.Add(new SqlParameter("@DateDebut", dateDebut));
                cmd.Parameters.Add(new SqlParameter("@DateFin", dateFin));

                dt = new SqlDataAdapter(cmd);

                // Remplir le DataSet avec le résultat de la procédure
                dt.Fill(dst, nomTable);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dt.Dispose();
                con.Close();
            }

            return dst;
        }

        public DataSet getJournalsEntreDates(DateTime dateDebut, DateTime dateFin, string nomTable)
        {
            con = new dataconnexion().DBConnect();
            DataSet dst = new DataSet();
            try
            {
                if (!con.State.ToString().ToLower().Equals("open")) con.Open();

                // Préparer la commande pour exécuter la procédure stockée
                SqlCommand cmd = new SqlCommand("GetJournalsEntreDates", con);
                cmd.CommandType = CommandType.StoredProcedure;

                // Ajouter les paramètres de date
                cmd.Parameters.Add(new SqlParameter("@DateDebut", dateDebut));
                cmd.Parameters.Add(new SqlParameter("@DateFin", dateFin));

                dt = new SqlDataAdapter(cmd);

                // Remplir le DataSet avec le résultat de la procédure
                dt.Fill(dst, nomTable);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dt.Dispose();
                con.Close();
            }

            return dst;
        }

        public DataSet get_Report_Z(string nomTable)
        {
            con = new dataconnexion().DBConnect();
            Console.WriteLine("exec" + nomTable);
            DataSet dst;
            try
            {
                if (!con.State.ToString().ToLower().Equals("open")) con.Open();
                SqlCommand cmd = new SqlCommand("exec " + nomTable, con);
                dt = new SqlDataAdapter(cmd);
                dst = new DataSet();
                dt.Fill(dst, nomTable);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dt.Dispose(); con.Close();
            }
            return dst;
        }

        //==========================METHODE D'IMPRESSION D'UNE facture total=============
        public DataSet get_Report_facturetotal(string colonnes, string nomTable)
        {
            con = new dataconnexion().DBConnect();
            Console.WriteLine("SELECT  " + colonnes + " FROM " + nomTable);
            DataSet dst;
            try
            {
                //   innitialiseConnect();
                if (!con.State.ToString().ToLower().Equals("open")) con.Open();
                SqlCommand cmd = new SqlCommand("SELECT  " + colonnes + " FROM " + nomTable, con);
                //  cmd.Parameters.AddWithValue("@valchamp", valchamp);
                dt = new SqlDataAdapter(cmd);
                dst = new DataSet();
                dt.Fill(dst, nomTable);

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dt.Dispose(); con.Close();
            }
            return dst;
        }

        public DataSet get_Report_S(string nomTable, string idTable)
        {
            con = new dataconnexion().DBConnect();
            DataSet dst;
            try
            {
                //innitialiseconnect();
                if (!con.State.ToString().ToLower().Equals("open")) con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM " + nomTable + " ORDER BY " + idTable + "", con);
                dt = new SqlDataAdapter(cmd);
                dst = new DataSet();
                dt.Fill(dst, nomTable);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dt.Dispose(); con.Close();
            }
            return dst;
        }

        //==========================IMPRESSION DE 'UN BON D'ENTRER STOCK===========================//
        public DataSet get_Report_Bon_entrer_stock(string nomTable, string datetable, string fournisseur, string value, string value2)
        {
            con = new dataconnexion().DBConnect();
            DataSet dst;
            try
            {
                //innitialiseconnect();
                if (!con.State.ToString().ToLower().Equals("open")) con.Open();
                SqlCommand cmd = new SqlCommand("select * from Vachat WHERE dateAchat =@date and fournisseur= @fournisseur", con);
                cmd.Parameters.AddWithValue("@date", value);
                cmd.Parameters.AddWithValue("@fournisseur", value2);
                dt = new SqlDataAdapter(cmd);
                dst = new DataSet();
                dt.Fill(dst, nomTable);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dt.Dispose(); con.Close();
            }
            return dst;
        }

        //==========================IMPRESSION DE 'UN BON DE SORTIE STOCK===========================//
        public DataSet get_Report_Bon_sortie_stock(string nomTable, string datetable, string client, string value, string value2)
        {
            con = new dataconnexion().DBConnect();
            DataSet dst;
            try
            {
                //innitialiseconnect();
                if (!con.State.ToString().ToLower().Equals("open")) con.Open();
                SqlCommand cmd = new SqlCommand("select * from Vvente WHERE dateVente =@date and client =@client", con);
                cmd.Parameters.AddWithValue("@date", value);
                cmd.Parameters.AddWithValue("@client", value2);
                dt = new SqlDataAdapter(cmd);
                dst = new DataSet();
                dt.Fill(dst, nomTable);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dt.Dispose(); con.Close();
            }
            return dst;
        }
    }
}
