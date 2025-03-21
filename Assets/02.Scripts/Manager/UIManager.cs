using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
    
// 다른 UI를 끄고 키는 용도로 사용
public class UIManager : MonoBehaviour
{
    [Header("UIMainMenu")]
    [SerializeField] private UIMainMenu uiMainMenu;
    public GameObject uiMainMenuPanel;
    
    [Header("UIMainMenu")]
    [SerializeField] private UIStat uiStat;
    public GameObject statPanel;
    
    [Header("UIMainMenu")]
    [SerializeField] private UIInventory uiInventory;
    public GameObject inventoryPanel;

}
