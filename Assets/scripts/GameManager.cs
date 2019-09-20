using UnityEngine;
using UnityEngine.UI;

public class GameManager : Singleton<GameManager>
{
    [SerializeField]
    Text memoryText;

    public int Memory { get; set; }

    public TowerBtn ClickedTowerBtn { get; set; }

    public void OnValidate()
    {
        Memory = 200;
        memoryText.text = Memory.ToString();
    }

    public bool TowerCanBePlaced()
    {

        if(ClickedTowerBtn != null)
        {
            if (Memory >= ClickedTowerBtn.GetPrice())
            {
                Memory -= ClickedTowerBtn.GetPrice();
                memoryText.text = Memory.ToString();

                return true;

            }
        }        

        return false;

    }

    public void SetClickedButton(TowerBtn clickedTowerBtn)
    {

        if(this.ClickedTowerBtn != null)
        {
            this.ClickedTowerBtn.Deselect();
        }

        this.ClickedTowerBtn = clickedTowerBtn;

    }

}
