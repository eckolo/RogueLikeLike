using UnityEngine;
using UnityEditor;

namespace Assets.Src.Models
{
    public class Adjective : ScriptableObject, Stationery.INamed
    {
        public new string name => _name;
        [SerializeField]
        string _name;

        public string description => _description;
        [SerializeField]
        string _description;
    }
}