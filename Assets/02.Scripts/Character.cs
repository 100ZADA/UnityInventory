using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Character
{
    public string name;
    public int health;
    public int attack;
    public int speed;
    public int coin;

    // 생성자
    public Character(string name, int health, int attack, int speed, int coin)
    {
        this.name = name;
        this.health = health;
        this.attack = attack;
        this.speed = speed;
        this.coin = coin;
    }
}
