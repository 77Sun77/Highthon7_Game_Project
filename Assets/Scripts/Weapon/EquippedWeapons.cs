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
        if (weaponsName == "주먹")
        {
            CharacterController.weaponDamage = 1;
            CharacterController.attackRange = 2f;
            CharacterController.attackDelay = 1f;
            CharacterController.animPrefab = punch;
            playerAnim.runtimeAnimatorController = anim[0];
        }

        if (weaponsName == "대걸레")
        {
            CharacterController.weaponDamage = 2;
            CharacterController.attackRange = 4;
            CharacterController.attackDelay = 1.7f;
            CharacterController.animPrefab = baseballBat;
            playerAnim.runtimeAnimatorController = anim[1];
        }

        if (weaponsName == "책")
        {
            CharacterController.weaponDamage = 2;
            CharacterController.attackRange = 2f;
            CharacterController.attackDelay = 1f;
            CharacterController.animPrefab = book;
            playerAnim.runtimeAnimatorController = anim[2];
        }
        
        if (weaponsName == "분필")
        {
            CharacterController.weaponDamage = 1;
            CharacterController.attackRange = 5;
            CharacterController.attackDelay = 0.5f;
            playerAnim.runtimeAnimatorController = anim[3];
        }

        if (weaponsName == "나무배트")
        {
            CharacterController.weaponDamage = 3;
            CharacterController.attackRange = 3f;
            CharacterController.attackDelay = 1.7f;
            CharacterController.animPrefab = baseballBat;
            playerAnim.runtimeAnimatorController = anim[4];
        }
        
        if (weaponsName == "빗자루와 쓰레받이")
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
        if (weaponsName == "책")
        {
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
            StartCoroutine(chalkSkill());
        }

        if (weaponsName == "대걸레")
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
