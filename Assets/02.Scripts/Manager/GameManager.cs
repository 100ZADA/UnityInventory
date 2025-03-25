using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public UIInventory uiInventory;
    
    public Character Character { get; private set; }
    
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        
        SetData();
    }

    private void SetData()
    {
        Character = new Character("초보자", 100, 10, 5, 1000);
        
        // 아이템 추가
        Character.AddItem(new Item("삽", 3));
        Character.AddItem(new Item("갈퀴", 9));
        Character.AddItem(new Item("낫", 15));
        
        uiInventory.RefreshSlots();
    }
}