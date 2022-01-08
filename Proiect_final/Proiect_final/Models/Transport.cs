using System;
using System.Collections.Generic;
using System.Text;
using SQLite;


namespace Proiect_final.Models
{
    public class Transport
    {
        [PrimaryKey, AutoIncrement]
        public int ID_transport { get; set; }
        public string Tip_transport { get; set; }
        public string Nume_firma { get; set; }



    }
}

