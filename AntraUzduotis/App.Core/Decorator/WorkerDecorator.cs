using App.Core.Interface;
using App.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Core.Decorator
{
    public abstract class WorkerDecorator : IWorker
    {
        public readonly IWorker worker;

        public WorkerDecorator(IWorker worker)
        {
            this.worker = worker;
        }

        public void workPlace(Restaurant newRestaurant)
        {
            this.worker.workPlace(newRestaurant);
        }

        public void makeDish()
        {
            this.worker.makeDish();
        }
    }
}
