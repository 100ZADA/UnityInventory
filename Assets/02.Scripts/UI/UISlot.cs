using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    [SerializeField] private Image icon; // 아이템에 따른 이미지
    private Item inventoryItem;

    // 아이템을 슬롯에 할당
    public void SetItem(Item item)
    {
        inventoryItem = item;
        
        if (inventoryItem != null)
        {
            icon.sprite = item.Icon;
            icon.enabled = true;
        }
        else
        {
            ClearItem();
        }
    }

    // 아이템 없을 시 슬롯 비우기
    public void ClearItem()
    {
        inventoryItem = null;
        icon.sprite = null;
        icon.enabled = false;
    }
}