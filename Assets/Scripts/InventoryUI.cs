
using System;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    private ControlsManager controls;
    
    public Transform itemsParent;
    public GameObject inventoryUI;
    
    private Inventory inventory;

    private InventorySlot[] slots;
    private void Start()
    {
        controls = GameObject.Find("ControlsManager").GetComponent<ControlsManager>();
        inventory = Inventory.instance;
        inventory.onItemChangedCallback += UpdateUI;

        slots = itemsParent.GetComponentsInChildren<InventorySlot>();
    }

    private void Update()
    {
        if (controls.InventoryToggled())
        {
            inventoryUI.SetActive(!inventoryUI.activeSelf);
        }
    }

    void UpdateUI()
    {
        for (int i = 0; i < slots.Length; i++)
        {
            if (i < inventory.items.Count)
            {
                slots[i].AddItem(inventory.items[i]);
            }
            else
            {
                slots[i].ClearSlot();
            }
        }
    }
}
