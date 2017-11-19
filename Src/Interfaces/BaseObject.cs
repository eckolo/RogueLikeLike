using UnityEngine;
using UnityEditor;

abstract class BaseObject
{
    public string name => _name;
    [SerializeField]
    string _name;
    public string description => _description;
    [SerializeField]
    string _description;
}