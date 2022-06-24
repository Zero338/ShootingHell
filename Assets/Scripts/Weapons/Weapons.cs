using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Data", menuName = "Weapons/Ranged", order = 1)]
public class Weapons : ScriptableObject
{

    //BasicInformation
    public float Ammo;
    public float Damage;

    //Weapon list 
    public enum WeaponType { Pistol, Rifle, RocketLauncher, GrenadeLauncher}
    public WeaponType Weapon;

    //Weapon Grade for rarity
    public enum WeaponGrade { Bad, Ok, Good, Great, Fantastic}
    public WeaponGrade Quality;
    // Start is called before the first frame update
    void Start()
    {
        Ammo = 5;
        Damage = 4;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
