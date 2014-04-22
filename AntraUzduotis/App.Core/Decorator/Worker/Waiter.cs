using App.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Decorator.Worker
{
    public class Waiter : WorkerDecorator
    {
        private double _tips;

        public Waiter(IWorker worker) : base(worker)
        {
            this._tips = 0.0;
        }

        public double receiveTips(double tips)
        {
            this._tips += tips;

            return this._tips;
        }
    }
}
