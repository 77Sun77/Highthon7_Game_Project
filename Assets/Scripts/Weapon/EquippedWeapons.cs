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
    public GameObject mopSkill;


    CharacterController c1;

    [Header("Animator")]
    public RuntimeAnimatorController[] anim;
    Animator playerAnim;
    void Start()
    {
        c1 = GameObject.Find("GameManager").GetComponent<CharacterController>();
        playerAnim = c1.player2.GetComponent<Animator>();
    }

    
    void Update()
    {
        if (weaponsName == "�ָ�")
        {
            CharacterController.weaponDamage = 1;
            CharacterController.attackRange = 2f;
            CharacterController.attackDelay = 1f;
            CharacterController.animPrefab = punch;
            playerAnim.runtimeAnimatorController = anim[0];
        }

        if (weaponsName == "��ɷ�")
        {
            CharacterController.weaponDamage = 2;
            CharacterController.attackRange = 4;
            CharacterController.attackDelay = 1.7f;
            CharacterController.animPrefab = baseballBat;
            playerAnim.runtimeAnimatorController = anim[1];
        }

        if (weaponsName == "å")
        {
            CharacterController.weaponDamage = 2;
            CharacterController.attackRange = 2f;
            CharacterController.attackDelay = 1f;
            CharacterController.animPrefab = book;
            playerAnim.runtimeAnimatorController = anim[2];
        }
        
        if (weaponsName == "����")
        {
            CharacterController.weaponDamage = 1;
            CharacterController.attackRange = 5;
            CharacterController.attackDelay = 0.5f;
            playerAnim.runtimeAnimatorController = anim[3];
        }

        if (weaponsName == "������Ʈ")
        {
            CharacterController.weaponDamage = 3;
            CharacterController.attackRange = 3f;
            CharacterController.attackDelay = 1.7f;
            CharacterController.animPrefab = baseballBat;
            playerAnim.runtimeAnimatorController = anim[4];
        }
        
        if (weaponsName == "���ڷ�� ��������")
        {
            CharacterController.weaponDamage = 1;
            CharacterController.attackRange = 2f;
            CharacterController.attackDelay = 0.5f;
            CharacterController.animPrefab = broomstickAttack;
            CharacterController.shieldPrefab = broomstickShield;
            playerAnim.runtimeAnimatorController = anim[5];
        }
    }

    public void skill()
    {
        if (weaponsName == "å")
        {
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
            StartCoroutine(chalkSkill());
        }

        if (weaponsName == "��ɷ�")
        {
            Instantiate(mopSkill, c1.player2.transform);
        }
    }


    IEnumerator chalkSkill()
    {
        yield return new WaitForSeconds(0.2f);
        for (int i=0; i < 10; i++)
        {
            yield return new WaitForSeconds(0.08f);
            GameObject chalkGO = Instantiate(c1.chalk);
            chalkGO.transform.position = c1.player2.transform.position;
            Chalk chalkGo = chalkGO.GetComponent<Chalk>();
            chalkGo.vEnd = c1.targetMonster.transform.position;
            
        }
    }

}
