using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InventorySlotScript : MonoBehaviour, IPointerClickHandler
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
    private Text memory;

    [SerializeField]
    private Text range;

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

    public void SetItem(GameObject item)
    {

        this.item = item;

        TowerScript tower = this.item.GetComponent<TowerScript>();
       
        icon.sprite = item.GetComponent<SpriteRenderer>().sprite;
        name.text = tower.Name;
        memory.text = tower.Price.ToString();
        element.text = tower.Element;
        damage.text = tower.Damage.ToString();
        range.text = tower.Range.ToString();
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (item != null)
        {
            GameManager.Instance.ClickedTowerBtn.AddTower(item);
        }
    }
}
