using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIStat : MonoBehaviour
{
    public Button statBackBtn;

    // chracter 정보 세팅 메서드 추가
    
    void Start()
    {
        statBackBtn.onClick.AddListener(CloseStatMenu);
    }

    public void CloseStatMenu()
    {
        UIManager.instance.UIMainMenuPanel.gameObject.SetActive(true);
        UIManager.instance.UIStat.gameObject.SetActive(false);
    }
}
