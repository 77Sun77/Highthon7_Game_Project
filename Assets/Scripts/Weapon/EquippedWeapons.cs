using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquippedWeapons : MonoBehaviour
{
    public static string weaponsName = "나무배트";

    public GameObject baseballBat;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (weaponsName == "대걸레")
        {
            CharacterController.weaponDamage = 2;
            CharacterController.attackRange = 4;
            CharacterController.attackDelay = 1.7f;
        }

        if (weaponsName == "책")
        {
            CharacterController.weaponDamage = 2;
            CharacterController.attackRange = 2f;
            CharacterController.attackDelay = 1f;
        }
        
        if (weaponsName == "분필")
        {
            CharacterController.weaponDamage = 1;
            CharacterController.attackRange = 5;
            CharacterController.attackDelay = 0.5f;
        }

        if (weaponsName == "나무배트")
        {
            CharacterController.weaponDamage = 3;
            CharacterController.attackRange = 3f;
            CharacterController.attackDelay = 1.7f;
            CharacterController.animPrefab = baseballBat;
        }
        
        if (weaponsName == "빗자루와 쓰레받이")
        {
            CharacterController.weaponDamage = 1;
            CharacterController.attackRange = 2f;
            CharacterController.attackDelay = 0.5f;
        }
    }
}
