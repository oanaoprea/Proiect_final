using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Proiect_final.Models
{
    public class Destinatii
    {
        [PrimaryKey, AutoIncrement]
        public int ID_destinatie { get; set; }
        public string Oras { get; set; }
        public string Tara { get; set; }

    }
}
