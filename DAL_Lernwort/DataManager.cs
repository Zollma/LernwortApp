﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using BO_Lernwort;

namespace DAL_Lernwort
{

    public class DataManager
    {
        private string strFilePathname = "D:\\Softwareentwicklung\\Visual Studio 2017\\Projects\\LernwortApp\\DAL_Lernwort\\Lernwortsets.accdb ";
        private OleDbConnection con = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader reader;
        private List<LernwortClass> listLernwort = new List<LernwortClass>();
        private List<LernsetClass> listLernset = new List<LernsetClass>();
        

        public DataManager()
        {
            con.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; " + "Data Source =" + strFilePathname;
            cmd.Connection = con;           
        }

        //----------------------------------------------------------------------------
        // methods to get Data from table Lernset
        //----------------------------------------------------------------------------
        public List<LernsetClass> ReadListOfLernset()
        {
            cmd.CommandText = "SELECT * FROM Lernset";

            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int lrnID = Convert.ToInt16(reader["LernsetID"]);
                    string bschr = ""+reader["Beschreibung"];
                    string lrnst = "" + reader["Lernsetstatus"];
                    DateTime erstellt = Convert.ToDateTime(reader["Erstellt"]);
                    DateTime gelernt = new DateTime();
                    if (!("" == ""+reader["Gelernt"]  ))
                    {
                        gelernt = Convert.ToDateTime(reader["Gelernt"]);
                    }
                    listLernset.Add(new LernsetClass(lrnID, bschr, lrnst, erstellt, gelernt));
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            reader.Close();
            con.Close();

            return listLernset;
        }

        public int GetCountLernedSets()
        {
            int count = 0;

            cmd.CommandText = "SELECT COUNT (LernsetID) AS count_lrnID FROM Lernset WHERE Lernsetstatus = 'gelernt'";

            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                  count = Convert.ToInt16(reader["count_lrnID"]);
                    
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            reader.Close();
            con.Close();

            return count;
        }

        private bool DeleteLernset(int lernsetID)
        {
            bool blDeleted = false;
            cmd.CommandText = "DELETE * FROM Lernwort WHERE LernsetID =" + lernsetID;
            try
            {
                con.Open();
                int deletedNum = cmd.ExecuteNonQuery();
               
                cmd.CommandText = "DELETE * FROM Lernset WHERE LernsetID =" + lernsetID;
                deletedNum = cmd.ExecuteNonQuery();
                if (deletedNum > 0)
                {
                    blDeleted = true;
                }
                con.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return blDeleted;
        }

        public int DeleteLernsets(List<int> lernsetId)
        {
            int countDeleted = 0;
            int count = lernsetId.Count;
            for (int i = 0; i < count; i++)
            {
                if (DeleteLernset(lernsetId[i]))
                    countDeleted++;
            }
            return countDeleted;
        }

        public LernsetClass GetNewLernset(string bschrbng)
        {
            int lernsetID = GetNewLernsetID();
            string lernsetstatus = LernsetClass.UNGELERNT;
            DateTime erstellt = new DateTime();
            erstellt = DateTime.Today;
            DateTime gelernt  = new DateTime();

            
            cmd.CommandText = "INSERT INTO Lernset (LernsetID, Beschreibung, Lernsetstatus, Erstellt, Gelernt) VALUES (" + lernsetID + ",'" + bschrbng + "', '" +lernsetstatus+ "','"+ erstellt+ "','"+ gelernt+"')";
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            
            LernsetClass lernset = new LernsetClass(lernsetID, bschrbng, lernsetstatus, erstellt, gelernt);

            return lernset;
        }

        private int GetNewLernsetID()
        {
            int newlernsetID = 0;
            
            cmd.CommandText = "SELECT * FROM Lernset";

            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int lernsetID = Convert.ToInt16(reader["LernsetID"]);
                    if (lernsetID > newlernsetID)
                    {
                        newlernsetID = lernsetID;
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            reader.Close();
            con.Close();
            newlernsetID++;


            return newlernsetID;
        }
        //----------------------------------------------------------------------------
        // methods to get Data from table Lernwort
        //----------------------------------------------------------------------------
        public List<LernwortClass> GetListOfLernwords(List<int> lernsetId)
        {
            //empty the lernwordList 

            //fill the lernwordList 
            int count = lernsetId.Count;
            for (int i = 0; i < count; i++)
            {
                ReadLernw(lernsetId[i]);
            }
                return listLernwort;
        }
        
        private void ReadLernw(int lstID)
        {
            cmd.CommandText = "SELECT * FROM Lernwort WHERE LernsetID =" + lstID;

            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int wrt = Convert.ToInt16(reader["WortID"]);
                    int lrnId = Convert.ToInt16(reader["LernsetID"]);
                    string lrnwrt = "" + reader["Lernwort"];
                    int lrndrch = Convert.ToInt16(reader["Lerndurchlauf"]);
                    listLernwort.Add(new LernwortClass(wrt, lrnId, lrnwrt, lrndrch));
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            reader.Close();
            con.Close();
        }

        public int GetCountLernwords()
        {
            int count = 0;

            cmd.CommandText = "SELECT COUNT (WortID) AS count_wortID FROM Lernwort";

            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    count = Convert.ToInt16(reader["count_wortID"]);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            reader.Close();
            con.Close();

            return count;
        }

        public void EditLernword(string word, int wordID)
        {
            cmd.CommandText = "UPDATE Lernwort SET  Lernwort = '"+ word +"' WHERE WortID =" + wordID;
            int count = 0;
            try
            {
                con.Open();
                count = cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int NewLernword(string word, int lernsetID)
        {
            int newWrid = GetNewWordID();
            cmd.CommandText = "INSERT INTO Lernwort (WortID, LernsetID, Lernwort, Lerndurchlauf) VALUES (" +newWrid+","+ lernsetID+",'"+ word+ "', 0)";
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return newWrid;
        }

        private int GetNewWordID()
        {
            int newWordID = 0;
            
            cmd.CommandText = "SELECT * FROM Lernwort";

            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    int wordID = Convert.ToInt16(reader["WortID"]);
                    if(wordID > newWordID)
                    {
                        newWordID = wordID;
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            reader.Close();
            con.Close();
            newWordID++;

            return newWordID; 
        }

        public bool DeleteLernword(int wordID)
        {
            bool blDeleted = false;
            cmd.CommandText = "DELETE FROM Lernwort WHERE WortID =" + wordID;
            try
            {
                con.Open();
                int deletedNum = cmd.ExecuteNonQuery();
                if(deletedNum > 0)
                {
                    blDeleted = true;
                }
                con.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            
            return blDeleted;
        }
    }
}
