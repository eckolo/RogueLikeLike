using UnityEngine;
using UnityEditor;

public interface INamedObject
{
    string name { get; set; }
    string description { get; set; }
}