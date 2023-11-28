using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace app8.mode
{
    public class tocv
    {
        [AutoIncrement, PrimaryKey]
        public int id { get; set; }
        public string name { get; set; }
        public string apellido { get; set; }
        public string perfil { get; set; }
        public string contacto { get; set; }
        public string idiomas { get; set; }
        public string habilidades { get; set; }
    }
}
