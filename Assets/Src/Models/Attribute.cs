using UnityEngine;
using UnityEditor;

namespace Src.Models
{
    public class Attribute : ScriptableObject, Interfaces.INamedObject
    {
        public string description { get; }
    }
}