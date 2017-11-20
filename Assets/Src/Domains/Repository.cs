using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Src.Domains
{
    abstract class Repository<Resource> where Resource : ScriptableObject
    {
        abstract protected string directory { get; }
        abstract public Resource GetResource(string name);
    }
}
