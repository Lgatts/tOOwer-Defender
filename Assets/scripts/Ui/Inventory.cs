using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : Singleton<Inventory>
{

    [SerializeField]
    private List<GameObject> items = new List<GameObject>();
  

    public void Add(GameObject gameObject)
    {

        this.items.Add(gameObject);

    }


}
