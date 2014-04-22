using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Models
{
    public class SuperWorker : AbstractWorker
    {
        public SuperWorker(string name, Restaurant restaurant) : base(name, restaurant)
        {
        }

        public override void makeDish()
        {
            Console.Out.WriteLine(String.Format("{0} pagamino dviguba mesaini.", this.Name));
        }
    }
}
