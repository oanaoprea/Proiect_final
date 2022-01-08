using System;
using System.Collections.Generic;
using System.Text;
using SQLite;


namespace Proiect_final.Models
{
    public class Contract
    {
        [PrimaryKey, AutoIncrement]
        public int ID_contract { get; set; }
        public string Nume_cazare { get; set; }
        public string Nume_transport { get; set; }
    }
}


