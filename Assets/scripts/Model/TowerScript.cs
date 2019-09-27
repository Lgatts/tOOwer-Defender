using System;
using System.Collections.Generic;
using UnityEngine;

public class TowerScript : MonoBehaviour
{

    [SerializeField]
    private int price;

    [SerializeField]
    private int damage;

    [SerializeField]
    private int range;

    [SerializeField]
    private new string name;

    [SerializeField]
    private string element;

    [SerializeField]
    private List<string> methods;

    [SerializeField]
    private List<GameObject> pads;

    private List<string> inheritedMethods;

    public TowerScript()
    {
        inheritedMethods = new List<string>();
    }

    public int Range { get => range; set => range = value; }

    public int Damage { get => damage; set => damage = value; }

    public int Price { get => price; set => price = value; }

    public string Name { get => name; set => name = value; }

    public string Element { get => element; set => element = value; }

    public List<string> Methods { get => methods; set => methods = value; }

    public List<string> InheritedMethods { get => inheritedMethods; set => inheritedMethods = value; }

    public List<GameObject> Pads { get => pads; set => pads = value; }
}
