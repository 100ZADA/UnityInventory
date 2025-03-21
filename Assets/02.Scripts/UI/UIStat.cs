using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIStat : MonoBehaviour
{
    public Button statBackBtn;

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
