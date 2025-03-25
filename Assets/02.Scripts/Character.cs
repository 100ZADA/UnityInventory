using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;

[System.Serializable]
// 캐릭터 클래스
public class Character
{
    public string Name { get; private set; }
    public int Health { get; private set; }
    public int Attack { get; private set; }
    public int Speed { get; private set; }
    public int Coin { get; private set; }

    // 인벤토리 프로퍼티 추가
    public List<Item> Inventory { get; private set; }

    // 생성자
    public Character(string name, int health, int attack, int speed, int coin)
    {
        Name = name;
        Health = health;
        Attack = attack;
        Speed = speed;
        Coin = coin;

        // 인벤토리 추가
        Inventory = new List<Item>();
    }

    // 아이템 생성
    public void AddItem(Item item)
    {
        Inventory.Add(item);
    }

    // 아이템 착용
    public void EquipItem(Item item)
    {
        item.Equip();
    }

    // 아이템 해제
    public void UnEuipItem(Item item)
    {
        item.UnEquip();
    }
}