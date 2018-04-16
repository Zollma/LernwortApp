using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Lernwort;
using BO_Lernwort;

namespace BAL_Lernwort
{
    public class BAL_Manager
    {
        private DataManager dataMngr = new DataManager();
        private List<LernsetClass> listLrnset = new List<LernsetClass>();

        public List<LernsetClass> GetDALLernsetList()
        {
            listLrnset = dataMngr.ReadListOfLernset();
            return listLrnset;
        }

        public int GetNumberOfLernsets()
        {
            int num = listLrnset.Count;
            return num;
        }

        public int DeleteLernset(List<int> lernsetId)
        {
            return dataMngr.DeleteLernsets(lernsetId);
        }
        //-------------------------Lernwords Handeling---------------------------------------

        public int GetNumberOfLernwords()
        {
            int num = dataMngr.GetCountLernwords();
            return num; 
        }

        public int GetPercentageLerned()
        {
            int percentage = 0;
            int num = listLrnset.Count;
            int numGlrnt = dataMngr.GetCountLernedSets();
            percentage = numGlrnt * 100 / num;
            return percentage;
        }

        public List<LernwortClass> GetListOfLernwords(List<int> lernsetId)
        {
            List<LernwortClass> list = new List<LernwortClass>();
            list = dataMngr.GetListOfLernwords(lernsetId); 
            return list;
        }

        public void EditWord(string word, int wordID)
        {
            dataMngr.EditLernword(word, wordID);
        }

        public int NewWord(string word, int lernsetID)
        {
            return dataMngr.NewLernword(word, lernsetID);

        }

        public bool DeleteWord(int wordID)
        {
            return dataMngr.DeleteLernword(wordID);
        }
    }
}
