using UnityEngine;
using UnityEngine.EventSystems;

public class CloseInventory : MonoBehaviour, IPointerClickHandler
{
    [SerializeField]
    private Canvas invetoryCanvas;

    public void OnPointerClick(PointerEventData eventData)
    {
        invetoryCanvas.enabled = false;
    }
}
