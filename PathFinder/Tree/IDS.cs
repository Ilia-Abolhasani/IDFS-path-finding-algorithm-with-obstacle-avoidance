using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathFinder.Tree
{
    public class IDS
    {
        public static int LastChildFinded= 0;
        public static int ChildFinded = 0;        
        public Node Head=null;
        public Node Answer= null;
        public IDS()
        {            
        }
        public void Start()
        {
            Head = new Node(null, Data.StartHome.x, Data.StartHome.y);
            for (int Limitation = 1; true; Limitation++)
            {
               Answer= Head.Search(Limitation);
               if (Answer!=null)
                   break; 
               if (ChildFinded - LastChildFinded == 0)
                   break;
               LastChildFinded = ChildFinded;
               ChildFinded = 0;
            }       
        }
    }
}
