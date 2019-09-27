using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryScript : Singleton<InventoryScript>
{
    private CanvasGroup canvasGroup;
    
    public bool IsOpen { get; set; }

    public TowerBtn ClickedBtn { get; set; }

    private void Awake()
    {
        this.canvasGroup = GetComponent<CanvasGroup>();
        this.IsOpen = false;
    }

    public void Open(TowerBtn clickedBtn)
    {

        this.ClickedBtn = clickedBtn;
        
        if (!this.IsOpen)
        {
            //canvasGroup.alpha = canvasGroup.alpha > 0 ? 0 : 1;

            //canvasGroup.blocksRaycasts = canvasGroup.blocksRaycasts == true ? false : true;

            


            IsOpen = true;
        }   

    }

    public void Close()
    {



    }



}
