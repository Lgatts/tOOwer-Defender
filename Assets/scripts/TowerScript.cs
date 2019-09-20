using UnityEngine;

public class TowerScript : MonoBehaviour
{

    [SerializeField]
    private int price;

    [SerializeField]
    private int damage;

    [SerializeField]
    private int range;

    [SerializeField]
    private new string name;

    [SerializeField]
    private string element;

    public int Range { get => range; set => range = value; }

    public int Damage { get => damage; set => damage = value; }

    public int Price { get => price; set => price = value; }

    public string Name { get => name; set => name = value; }

    public string Element { get => element; set => element = value; }
}
