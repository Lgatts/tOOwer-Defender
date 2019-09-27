using UnityEngine;
using UnityEngine.EventSystems;

public class CloseInventory : MonoBehaviour, IPointerClickHandler
{
    [SerializeField]
    private GameObject invetoryPanel;

    public void OnPointerClick(PointerEventData eventData)
    {
        invetoryPanel.SetActive(false);
    }
}
