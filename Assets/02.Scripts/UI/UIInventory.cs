using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    public Button inventoryBackBtn;
    
    [SerializeField] private UISlot slotPrefab;
    [SerializeField] private Transform parent;
    
    public List<UISlot> slots = new List<UISlot>();
    
    void Start()
    {
        inventoryBackBtn.onClick.AddListener(CloseInventoryMenu);
        InitInventory(15);
    }

    private void InitInventory(int count)
    {
        for (int i = 0; i < count; i++)
        {
            if (slotPrefab != null)
            {
                UISlot uiSlot = Instantiate(slotPrefab, parent);
                slots.Add(uiSlot);
            }
        }
    }

    public void CloseInventoryMenu()
    {
        UIManager.instance.UIMainMenu.gameObject.SetActive(true);
        UIManager.instance.UIInventory.gameObject.SetActive(false);
    }
}