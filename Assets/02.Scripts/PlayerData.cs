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
        name.text = character.Name;
        health.text = character.Health.ToString();
        attack.text = character.Attack.ToString();
        speed.text = character.Speed.ToString();
        coin.text = character.Coin.ToString();
    }
}
