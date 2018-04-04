using System;
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

        //----------------------------------------------------------------------------
        // methods to get Data from table Lernwort
        //----------------------------------------------------------------------------
        public List<LernwortClass> ReadLernw(int lstID)
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

            return listLernwort;
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


    }
}
