using System;


namespace BO_Lernwort
{
    //project BO (business objects) handels the table objects
    //class to represent the data from the table Lernset

    public class LernsetClass
    {
        public static string GELERNT = "gelernt";
        public static string UNGELERNT = "ungelernt";

        public int LernsetID { get; set; }
        public string Beschreibung { get; set; }
        public string Lernsetstatus { get; set; } //gelernt, ungelernt
        public DateTime Erstellt { get; set; }
        public DateTime Gelernt { get; set; }

        public LernsetClass(int lrnstID, string bschr, string lrnst, DateTime erstllt, DateTime glrnt)
        {
            LernsetID = lrnstID;
            Beschreibung = bschr;
            Lernsetstatus = lrnst;
            Erstellt = erstllt;
            Gelernt = glrnt;
        }

        public LernsetClass()
        {
            LernsetID = 0;
            Beschreibung = "";
            Lernsetstatus = LernsetClass.UNGELERNT;
            DateTime erstllt = new DateTime();
            erstllt = DateTime.Today;
            Erstellt = erstllt;
            DateTime glrnt = new DateTime();
            Gelernt = glrnt;
        }
    }
}
