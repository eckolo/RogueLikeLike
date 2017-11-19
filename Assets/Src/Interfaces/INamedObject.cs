using UnityEngine;
using UnityEditor;

namespace Src.Interfaces
{
    public interface INamedObject
    {
        string name { get; }
        string description { get; }
    }
}