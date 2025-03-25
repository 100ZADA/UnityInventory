using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
// 아이템 클래스
public class Item
{
    public Sprite icon;
    public string ItemName { get; private set; }
    public int ItemAttack { get; private set; }
    public bool isEquipped { get; private set; }

    // 생성자
    public Item(string itemName, int itemAttack)
    {
        ItemName = itemName;
        ItemAttack = itemAttack;
        isEquipped = false;
    }

    // 아이템 장착 
    public void Equip()
    {
        isEquipped = true;
    }

    // 아이템 해제
    public void UnEquip()
    {
        isEquipped = false;
    }
}