using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    public Button inventoryBackBtn;

    [SerializeField] private UISlot slotPrefab;
    [SerializeField] private Transform parent;

    public List<UISlot> slots = new List<UISlot>();

    void Start()
    {
        inventoryBackBtn.onClick.AddListener(CloseInventoryMenu);
        InitInventory(15);
    }

    private void InitInventory(int count)
    {
        for (int i = 0; i < count; i++)
        {
            if (slotPrefab != null)
            {
                UISlot uiSlot = Instantiate(slotPrefab, parent); // parent를 넣은 이유 프리팹 생성 위치 설정
                slots.Add(uiSlot); // 있어야 List에 프리팹 넣을 수 잇음
            }
        }
    }

    // 캐릭터의 아이템을 받아서 인벤토리 최신화 진행.
    public void RefreshSlots()
    {
        // 게임 매니저에서 캐릭터 안에 있는 인벤토리 데이터를 가져와 리스트화 진행
        List<Item> inventory = GameManager.instance.Character.Inventory;

            for (int i = 0; i < slots.Count; i++)
        {
            // 만약 인벤토리 카운터가 i보다 작을때
            if (i < inventory.Count)
            {
                // 인벤토리 슬롯 i번째에 아이템 i를 저장
                slots[i].SetItem(inventory[i]);
            }
            else
            {
                // 아니면 슬롯 비우기
                slots[i].ClearItem();
            }
        }
    }

    public void CloseInventoryMenu()
    {
        UIManager.instance.UIMainMenu.gameObject.SetActive(true);
        UIManager.instance.UIInventory.gameObject.SetActive(false);
    }
}