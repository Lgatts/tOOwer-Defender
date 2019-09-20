using UnityEngine;
using UnityEngine.UI;

public class InventorySlotScript : MonoBehaviour
{

    [SerializeField]
    private GameObject item;

    [SerializeField]
    private new Text name;

    [SerializeField]
    private Text damage;

    [SerializeField]
    private Text element;

    [SerializeField]
    private Text price;

    [SerializeField]
    private Image icon;

    public GameObject Item { get => item; set => item = value; }

    public void OnValidate()
    {
        if (item != null)
        {
            SetItem(item);
        }
    }
   
    public void OnClick()
    {
        if (item != null)
        {
            GameManager.Instance.ClickedTowerBtn.AddTower(item);
        }
    }


    public void SetItem(GameObject item)
    {

        this.item = item;

        TowerScript tower = this.item.GetComponent<TowerScript>();
       
        icon.sprite = item.GetComponent<SpriteRenderer>().sprite;
        name.text = tower.Name;
        price.text += tower.Price.ToString();
        element.text += tower.Element;
        damage.text += tower.Damage.ToString();
    }

}
