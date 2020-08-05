using Day2.Shared.Repository;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day2.Client.Pages
{
    public partial class Counter
    {
        [Inject] ServiceSimple singleton { get; set; }
        [Inject] ServiceTrasient transient { get; set; }

        private int currentCount = 0;

        private void IncrementCount()
        {
            currentCount++;
            singleton.Increase();
            transient.Increase();
        }
    }
}
