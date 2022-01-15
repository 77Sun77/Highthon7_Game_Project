using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquippedWeapons : MonoBehaviour
{
    public static string weaponsName = "빗자루와 쓰레받이";

    public GameObject baseballBat;
    public GameObject book;
    public GameObject punch;

    public GameObject broomstickAttack;
    public GameObject broomstickShield;


    [Header("Skill")]
    public GameObject broomstickSkill;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (weaponsName == "주먹")
        {
            CharacterController.weaponDamage = 1;
            CharacterController.attackRange = 2f;
            CharacterController.attackDelay = 1f;
            CharacterController.animPrefab = punch;
        }

        if (weaponsName == "대걸레")
        {
            CharacterController.weaponDamage = 2;
            CharacterController.attackRange = 4;
            CharacterController.attackDelay = 1.7f;
            CharacterController.animPrefab = baseballBat;
        }

        if (weaponsName == "책")
        {
            CharacterController.weaponDamage = 2;
            CharacterController.attackRange = 2f;
            CharacterController.attackDelay = 1f;
            CharacterController.animPrefab = book;
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
            CharacterController.animPrefab = broomstickAttack;
            CharacterController.shieldPrefab = broomstickShield;
        }
    }

    public void skill()
    {
        if (weaponsName == "책")
        {
            CharacterController c1 = GameObject.Find("GameManager").GetComponent<CharacterController>();
            c1.player2Hp += 4;
            print("회복");
            if (c1.player2Hp > c1.maxHp) c1.player2Hp = c1.maxHp;
        }

        if (weaponsName == "빗자루와 쓰레받이")
        {
            Instantiate(broomstickSkill);
        }

        if (weaponsName == "분필")
        {

        }
    }

    IEnumerator 
}
