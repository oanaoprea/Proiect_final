using System;
using System.Collections.Generic;
using System.Text;
using SQLite;


namespace Proiect_final.Models
{
    public class Cazare
    {
        [PrimaryKey, AutoIncrement]
        public int ID_cazare { get; set; }
        public string Tip_cazare { get; set; }
        public string Nume_cazare { get; set; }

        
    }
}




