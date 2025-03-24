using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    public Button statButton;
    public Button inventoryButton;
        
    // chracter 정보 세팅 메서드 추가
    
    private void Start()
    {
        statButton.onClick.AddListener(OpenStatMenu);
        inventoryButton.onClick.AddListener(OpenInventoryMenu);
    }

    public void OpenStatMenu()  
    {
        UIManager.instance.UIMainMenu.gameObject.SetActive(false);
        UIManager.instance.UIStat.gameObject.SetActive(true);
    }

    public void OpenInventoryMenu()
    {
        UIManager.instance.UIMainMenu.gameObject.SetActive(false);
        UIManager.instance.UIInventory.gameObject.SetActive(true);
    }
}
