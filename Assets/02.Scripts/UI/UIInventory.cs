using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    public Button inventoryBackBtn;

    void Start()
    {
        inventoryBackBtn.onClick.AddListener(CloseInventoryMenu);
    }

    public void CloseInventoryMenu()
    {
        UIManager.instance.UIMainMenuPanel.gameObject.SetActive(true);
        UIManager.instance.UIInventory.gameObject.SetActive(false);
    }
}
