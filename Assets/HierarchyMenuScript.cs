using UnityEngine;
using UnityEngine.UI;

public class HierarchyMenuScript : MonoBehaviour
{
    [SerializeField]
    Image towerSprite;
    
    void Start()
    {
        
        if(GameManager.Instance.ClickedTowerBtn != null)
        {
            towerSprite.sprite = GameManager.Instance.ClickedTowerBtn.TowerPrefab.GetComponent<SpriteRenderer>().sprite;
        }

    }

   
}
