using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace models.GameLogic.Models.Interfaces
{
    internal interface Player
    {
        public Guid GUID { get; }
        public string Name { get; set; }
        public List<Card> Cards { get; set; }

    }
}
