using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyManager : MonoBehaviour
{
    
    public EnemyStats.EnemyType EnemyType;
    public EnemyStats EnemyStats;
    public Weapons weapon;
    public GameObject EnemyUI;
    public Text Health;
    private float Damage;
    // Start is called before the first frame update
    void Start()
    {
        EnemyStats.Health = 100;
        Health.text = EnemyStats.Health.ToString();
        Damage = 10;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            EnemyStats.Health = EnemyStats.Health - Damage;
            Debug.Log("Damage Applied");
            Health.text = EnemyStats.Health.ToString();
        }
        if(EnemyStats.Health == 0)
        {
            EnemyStats.Health = 0;
            Debug.Log("Health is Dead");
        }
        
    }
}
