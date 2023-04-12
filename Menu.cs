using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBindingDemo2023
{
    public class Menu
    {
       public int Index = 0;
        public Cupcake[] Cupcakes =
      {
            new Cupcake("Chocolate Explosion", "An awesome...", "chocolate.png"),
            new Cupcake("Vanilla Something", "A description here...", "vanilla.png"),
            new Cupcake("Blueberry Bonanza", "description...", "blueberry.png")
        };
    }
}
