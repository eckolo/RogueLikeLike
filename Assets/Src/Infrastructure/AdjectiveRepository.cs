using Assets.Src.Domains;
using Assets.Src.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Src.Infrastructure
{
    class AdjectiveRepository : Repository<Adjective>
    {
        const string DIRECTORY = "Adjective/";
        public override Adjective GetResource(string name) => Resources.Load<Adjective>($"{DIRECTORY}{name}");
    }
}
