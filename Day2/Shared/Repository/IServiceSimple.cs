using System;
using System.Collections.Generic;
using System.Text;

namespace Day2.Shared.Repository
{
    public interface IServiceSimple
    {
        int GetCount();
        void Increase();
    }
}
