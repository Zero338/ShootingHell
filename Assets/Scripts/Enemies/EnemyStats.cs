using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Data", menuName = "Enemies/Small", order = 1)]
public class EnemyStats : ScriptableObject 
{
    //Stats
    public float Health;
    public float MaxHealth;
    public float Speed;
    public float Mana;
    public float ManaRegenRate;
    public float Damage;

    //Style of Enemies
    public enum EnemyType { Swordsman, Archer, Mage, NPC}
    public EnemyType enemytype;
    // Start is called before the first frame update
    void Awake()
    {
        Health = 100;
        MaxHealth = 100;
        Speed = 25;
        Mana = 100;
        ManaRegenRate = 10;
        Damage = 5;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
