using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquippedWeapons : MonoBehaviour
{
    public static string weaponsName = "���ڷ�� ��������";

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
        if (weaponsName == "�ָ�")
        {
            CharacterController.weaponDamage = 1;
            CharacterController.attackRange = 2f;
            CharacterController.attackDelay = 1f;
            CharacterController.animPrefab = punch;
        }

        if (weaponsName == "��ɷ�")
        {
            CharacterController.weaponDamage = 2;
            CharacterController.attackRange = 4;
            CharacterController.attackDelay = 1.7f;
            CharacterController.animPrefab = baseballBat;
        }

        if (weaponsName == "å")
        {
            CharacterController.weaponDamage = 2;
            CharacterController.attackRange = 2f;
            CharacterController.attackDelay = 1f;
            CharacterController.animPrefab = book;
        }
        
        if (weaponsName == "����")
        {
            CharacterController.weaponDamage = 1;
            CharacterController.attackRange = 5;
            CharacterController.attackDelay = 0.5f;
        }

        if (weaponsName == "������Ʈ")
        {
            CharacterController.weaponDamage = 3;
            CharacterController.attackRange = 3f;
            CharacterController.attackDelay = 1.7f;
            CharacterController.animPrefab = baseballBat;
        }
        
        if (weaponsName == "���ڷ�� ��������")
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
        if (weaponsName == "å")
        {
            CharacterController c1 = GameObject.Find("GameManager").GetComponent<CharacterController>();
            c1.player2Hp += 4;
            print("ȸ��");
            if (c1.player2Hp > c1.maxHp) c1.player2Hp = c1.maxHp;
        }

        if (weaponsName == "���ڷ�� ��������")
        {
            Instantiate(broomstickSkill);
        }

        if (weaponsName == "����")
        {

        }
    }

    IEnumerator 
}
