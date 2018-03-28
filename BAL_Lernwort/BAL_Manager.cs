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
        DataManager dataMngr = new DataManager();

        public List<LernsetClass> GetDALLernsetListe()
        {
            return dataMngr.LernsetListeAuslesen();
        }

        
    }
}
