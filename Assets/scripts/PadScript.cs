using UnityEngine;
using UnityEngine.EventSystems;

public class PadScript : MonoBehaviour, IPointerClickHandler
{

    GameObject tower;

    public Point GridPosition { get; set; }

    public void PlaceTower(GameObject towerPrefab)
    {

        if (towerPrefab != null)
        {
            if (this.tower == null)
            {
                Instantiate(towerPrefab, position: transform.position, rotation: Quaternion.identity);

                tower = towerPrefab;
            }
        }

    }

    public void OnPointerClick(PointerEventData eventData)
    {

        if (this.tower == null)
        {
            if (GameManager.Instance.TowerCanBePlaced())
            {
                PlaceTower(GameManager.Instance.ClickedTowerBtn.TowerPrefab);
            }

        }

    }
}


