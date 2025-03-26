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
        Application.targetFrameRate = 60;
        SetData();
    }

    private void SetData()
    {
        Character = new Character("초보자", 100, 10, 5, 1000);
        
        // 아이템 추가
        Character.AddItem(new Item("삽", 3, Resources.Load<Sprite>("Sprites/UI/Select_0")));
        Character.AddItem(new Item("갈퀴", 9, Resources.Load<Sprite>("Sprites/UI/Select_1")));
        Character.AddItem(new Item("낫", 15, Resources.Load<Sprite>("Sprites/UI/Select_2")));
        
        uiInventory.RefreshSlots();
    }
}