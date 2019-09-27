using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TowerBtn : MonoBehaviour, IPointerClickHandler
{

    [SerializeField]
    private Text memoryText;

    [SerializeField]
    private Image towerSprite;

    [SerializeField]
    private GameObject towerPrefab;

    [SerializeField]
    private GameObject inventoryPanel;

    [SerializeField]
    private GameObject towerMenuPanel;

    [SerializeField]
    private Color selectedColor;

    [SerializeField]
    private Color deselectedColor;

    [SerializeField]
    private Image panelColor;

    public GameObject TowerPrefab { get => towerPrefab; set => towerPrefab = value; }

    public void AddTower(GameObject towerPrefab)
    {
        this.towerPrefab = towerPrefab;

        towerSprite.sprite = towerPrefab.GetComponent<SpriteRenderer>().sprite;
        memoryText.text = towerPrefab.GetComponent<TowerScript>().Price.ToString();
    }

    public int GetPrice()
    {

        if (towerPrefab != null)
        {
            return towerPrefab.GetComponent<TowerScript>().Price;
        }
        else
        {
            return 0;
        }

    }

    private void UpdateDetailsPanel()
    {


    }

    public void OnPointerClick(PointerEventData eventData)
    {




        if (!inventoryPanel.activeSelf && this.TowerPrefab == null)
        {
            inventoryPanel.SetActive(true);
        }
        else if (this.TowerPrefab != null)
        {
            towerMenuPanel.SetActive(true);
            towerMenuPanel.GetComponent<TowerMenuScript>().UpdatePanel();
        }

        GameManager.Instance.SetClickedButton(this);

    }

    public void Deselect()
    {
        this.panelColor.color = deselectedColor;
        this.transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);
    }

    public void Select()
    {
        this.panelColor.color = selectedColor;
        this.transform.localScale = new Vector3(1.1f, 1.1f, 1.0f);
    }
}
