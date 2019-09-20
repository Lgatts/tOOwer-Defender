using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TowerBtn : MonoBehaviour, IPointerClickHandler
{

    [SerializeField]
    private Text memoryText;

    [SerializeField]
    private Sprite towerSprite;

    [SerializeField]
    private GameObject towerPrefab;

    [SerializeField]
    private Canvas invetoryPanel;

    [SerializeField]
    private Canvas towerDetails;

    public GameObject TowerPrefab { get => towerPrefab; set => towerPrefab = value; }
       
    public void AddTower(GameObject towerPrefab)
    {
        this.towerPrefab = towerPrefab;
       
        towerSprite = towerPrefab.GetComponent<SpriteRenderer>().sprite;
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
        if (towerPrefab != null)
        {
            if (!invetoryPanel.enabled)
            {
                if (!towerDetails.enabled)
                {
                    towerDetails.enabled = true;
                }

                UpdateDetailsPanel();
            }
        }
        else
        {
            invetoryPanel.enabled = true;
            towerDetails.enabled = false;
        }

        GameManager.Instance.SetClickedButton(this);
    }

    public void Deselect()
    {

       

    }

}
