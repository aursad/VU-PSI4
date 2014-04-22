using App.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Decorator.Worker
{
    public class DishWasher : WorkerDecorator
    {
        private int _washedPlates;

        public DishWasher(IWorker worker) : base(worker)
        {
            this._washedPlates = 0;
        }

        public int Wash(int plates)
        {
            this._washedPlates += plates;

            return this._washedPlates;
        }
    }
}
