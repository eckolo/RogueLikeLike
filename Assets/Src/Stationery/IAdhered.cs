using Assets.Src.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Src.Stationery
{
    interface IAdhered
    {
        List<Adjective> adjectives { get; set; }
        Adjective mainAdjective { get; }
    }
}
