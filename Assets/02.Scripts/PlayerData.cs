using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    [Header("InfoText")] 
    public TextMeshProUGUI name;
    public TextMeshProUGUI health;
    public TextMeshProUGUI attack;
    public TextMeshProUGUI speed;
    public TextMeshProUGUI coin;
    
    void Start()
    {
        
        Refresh(GameManager.instance.Character);
    }

    public void Refresh(Character character)
    {
        name.text = character.name;
        health.text = character.health.ToString();
        attack.text = character.attack.ToString();
        speed.text = character.speed.ToString();
        coin.text = character.coin.ToString();
    }
}
