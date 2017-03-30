using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Inventory : MonoBehaviour {
   public GameObject inventoryPanel;
    public GameObject slotPanel;
   public  GameObject inventorySlot;
   public  GameObject inventoryItem;

    int slotAmount;
    public List<Item> items = new List<Item>();
    public List<GameObject> slots = new List<GameObject>();

    void Start()
    {

        slotAmount = 20;
        inventorySlot.transform.localScale =new Vector3(0.1f, 0.1f, 0.1f);
          //slotPanel = inventoryPanel.transform.FindChild("Slot Panel").gameObject;
        for(int i =0; i<slotAmount;i++)
        {
            slots.Add(Instantiate(inventorySlot));
           
            slots[i].transform.SetParent(slotPanel.transform);
                
        }
    }
}
