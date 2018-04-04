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
    }
}
