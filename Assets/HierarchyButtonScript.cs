using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HierarchyButtonScript : MonoBehaviour
{

    [SerializeField]
    GameObject HierarchyPanel;

    public void OnClick()
    {
        HierarchyPanel.SetActive(true);
    }

}
