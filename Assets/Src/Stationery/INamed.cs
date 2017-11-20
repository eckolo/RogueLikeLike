using UnityEngine;
using UnityEditor;

namespace Assets.Src.Stationery
{
    public interface INamed
    {
        string name { get; }
        string description { get; }
    }
}