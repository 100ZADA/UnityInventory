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
    public UIMainMenu UIMainMenu { get; set; }
    public UIStat UIStat { get; set; }
    public UIInventory UIInventory { get; set; }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            UIMainMenu = uiMainMenu;
            UIStat = uiStat;
            UIInventory = uiInventory;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}