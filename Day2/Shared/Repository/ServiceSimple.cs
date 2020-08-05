using System;
using System.Collections.Generic;
using System.Text;

namespace Day2.Shared.Repository
{
    public class ServiceSimple: IServiceSimple
    {
        // DI
        //1. Singleton - Life time
        //2. Scope - Per Request
        //3. Trasient - Per Request

        private int currentCount;

        public void Increase()
        {
            currentCount++;
        }
        public int GetCount()
        {
            return currentCount;
        }
    }

    public class ServiceTrasient: IServiceSimple
    {
        private int currentCount;

        public void Increase()
        {
            currentCount++;
        }
        public int GetCount()
        {
            return currentCount;
        }
    }
}
