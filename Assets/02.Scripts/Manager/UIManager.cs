using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 다른 UI를 끄고 키는 용도로 사용
public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    [SerializeField] private UIMainMenu uiMainMenu;
    [SerializeField] private UIStat uiStat;
    [SerializeField] private UIInventory uiInventory;
    
    // 프로퍼티
    public UIMainMenu UIMainMenuPanel { get => uiMainMenu; set => uiMainMenu = value; }
    public UIStat UIStat { get => uiStat; set => uiStat = value; }
    public UIInventory UIInventory { get => uiInventory; set => uiInventory = value; }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}
