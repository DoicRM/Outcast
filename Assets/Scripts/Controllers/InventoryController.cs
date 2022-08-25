using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryController : MonoBehaviour
{
    private Player player;
    [SerializeField] private GameObject[] itemsSlots;
    private Text[] itemsSlotsText;
    public Text itemInfoDisplayer;
    public Text moneyDisplayer;

    void Awake()
    {
        player = GetComponent<PlayerController>().player;
        itemInfoDisplayer.text = "";
        moneyDisplayer.text = "Money: " + player.money.ToString();
    }

    void Start()
    {
        itemsSlotsText = new Text[itemsSlots.Length];
        int index = 0;
        foreach (GameObject itemsSlot in itemsSlots)
        {
            itemsSlotsText[index] = itemsSlot.GetComponentInChildren<Text>();
            index++;
        }
        SetInventoryItemsToSlots();
    }

    void SetInventoryItemsToSlots()
    {
        int index = 0;       
        foreach(GameObject itemsSlot in itemsSlots)
        {
            itemsSlotsText[index].text = player.inventory[index].name;
            index++;
        }
    }

    public void PrintItemInfo(int indexNr)
    {
        itemInfoDisplayer.text = player.inventory[indexNr].PrintInfo();
    }

    public void ClearItemInfoPrinter()
    {
        itemInfoDisplayer.text = "";
    }
}
