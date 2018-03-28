

namespace BO_Lernwort
{
    //project BO (business objects) handels the table objects
    //class to represent the data from the table Lernwort

    public class LernwortClass
    {
        public int WortID { get; set; }
        public int LernsetID { get; set; }
        public string Lernwort { get; set; }
        public int Lerndurchlauf { get; set; }

        public LernwortClass ()
        {

        }
        public LernwortClass(int wortId, int lernsetID, string lernwrt, int lerndrl)
        {
            WortID = wortId;
            LernsetID = lernsetID;
            Lernwort = lernwrt;
            Lerndurchlauf = lerndrl;
        }
    }
}
