using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquippedWeapons : MonoBehaviour
{
    public static string weaponsName = "����";
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (weaponsName == "��ɷ�")
        {
            CharacterController.weaponDamage = 2;
            CharacterController.attackRange = 0;
            CharacterController.attackDelay = 1.7f;
        }

        if (weaponsName == "å")
        {
            CharacterController.weaponDamage = 2;
            CharacterController.attackRange = 1.5f;
            CharacterController.attackDelay = 1f;
        }
        
        if (weaponsName == "����")
        {
            CharacterController.weaponDamage = 1;
            CharacterController.attackRange = 4;
            CharacterController.attackDelay = 0.5f;
        }

        if (weaponsName == "������Ʈ")
        {
            CharacterController.weaponDamage = 3;
            CharacterController.attackRange = 2.5f;
            CharacterController.attackDelay = 1.7f;
        }
        
        if (weaponsName == "���ڷ�� ��������")
        {
            CharacterController.weaponDamage = 1;
            CharacterController.attackRange = 1.5f;
            CharacterController.attackDelay = 0.5f;
        }
    }
}
