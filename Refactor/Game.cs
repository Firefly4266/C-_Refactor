using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactor
{
    public class Game
    {
        public List<object> Item { get; set; }
        public string userName { get; set; }
        public object inventory { get; set; }
        public void SaveGame(List<object> Item, string userName, object inventory)
        {
        }
    }
}
