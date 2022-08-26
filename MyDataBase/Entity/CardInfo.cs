using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDataBase.Entity
{
    public class CardInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CardType { get; set; }
        public DateTime DateRequested { get; set; }
    }
}
