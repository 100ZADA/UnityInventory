using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    public Button statButton;
    public Button inventoryButton;

    private void Start()
    {
        statButton.onClick.AddListener(OpenStatMenu);
        inventoryButton.onClick.AddListener(OpenInventoryMenu);
    }

    public void OpenStatMenu()
    {
        UIManager.instance.UIMainMenuPanel.gameObject.SetActive(false);
        UIManager.instance.UIStat.gameObject.SetActive(true);
    }

    public void OpenInventoryMenu()
    {
        UIManager.instance.UIMainMenuPanel.gameObject.SetActive(false);
        UIManager.instance.UIInventory.gameObject.SetActive(true);
    }
}
