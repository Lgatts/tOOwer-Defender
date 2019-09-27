using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class TowerMenuScript : MonoBehaviour
{
    [SerializeField]
    GameObject padsPanel;

    [SerializeField]
    Text methodsText;

    [SerializeField]
    private Text towerName;

    [SerializeField]
    private Text damage;

    [SerializeField]
    private Text element;

    [SerializeField]
    private Text memory;

    [SerializeField]
    private Text range;

    public void UpdatePanel()
    {
        if (GameManager.Instance.ClickedTowerBtn != null)
        {
            GameObject towerPrefab = GameManager.Instance.ClickedTowerBtn.TowerPrefab;

            SetPads(towerPrefab);
            SetMethods(towerPrefab);
            SetAttributes(towerPrefab);

        }
    }


    private void SetPads(GameObject towerPrefab)
    {
        TowerScript tower = towerPrefab.GetComponent<TowerScript>();

        foreach (GameObject pad in tower.Pads)
        {
            GameObject padObject = (GameObject)Instantiate(pad, padsPanel.transform);
            padObject.transform.localScale = new Vector3(300, 300, 1);
        }

    }

    private void SetMethods(GameObject towerPrefab)
    {

        TowerScript tower = towerPrefab.GetComponent<TowerScript>();

        StringBuilder stringBuilder = new StringBuilder();

        foreach (string method in tower.Methods)
        {
            stringBuilder.Append(method + "\n");
        }

        methodsText.text = stringBuilder.ToString();

    }

    private void SetAttributes(GameObject item)
    {

        TowerScript tower = item.GetComponent<TowerScript>();

        towerName.text = tower.Name;
        memory.text = tower.Price.ToString();
        element.text = tower.Element;
        damage.text = tower.Damage.ToString();
        range.text = tower.Range.ToString();
    }


}
