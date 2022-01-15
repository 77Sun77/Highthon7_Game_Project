using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [Header("Move")]
    public GameObject player1, player2;
    public Rigidbody2D rigid1, rigid2;
    public float maxSpeed;
    Vector2 mousePos;

    [Header("Attack")]
    RaycastHit2D hit;
    string hitTag;
    GameObject targetMonster;
    bool isAttack; // 공격 할 수 있는가
    bool attacking; // 현재 공격 중 인가
    public int maxHp;
    public int player2Hp = 10;
    public GameObject chalk; // 분필
    public static int skillPoint; // 스킬포인트
    public static float animTime; // 애니메이션 시전 시간
    public static float attackDelay; // 공속
    public static int weaponDamage; // 데미지
    public static float attackRange; // 범위

    public static GameObject animPrefab;
    Vector3 vStart, vEnd;
    float angle;
    void Start()
    {
        hitTag = "";
        isAttack = false;
        attacking = false;

        maxHp = 10;
        player2Hp = 10;

        animTime = 0.2f;
        attackRange = 1.5f;
        attackDelay = 1;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);
            RaycastHit2D hit = Physics2D.Raycast(mousePos, Vector2.zero, 0f);
            if (hit.collider != null)
            {
                this.hit = hit;
                hitTag = hit.collider.gameObject.tag;
            }
            else
            {
                isAttack = false;
                hitTag = "";
            }
                

            if (hitTag == "Monster")
            {
                targetMonster = hit.collider.gameObject;
                isAttack = true;
            }
        }
    }

    private void FixedUpdate()
    {
        player1Move();
        player2Move();
    }

    void player1Move()
    {
        float h = Input.GetAxis("Horizontal");
        float w = Input.GetAxis("Vertical");
        rigid1.velocity = new Vector2(h, w) * maxSpeed;
    }

    void player2Move()
    {
        player2.transform.position = Vector3.Lerp(player2.transform.position, mousePos, (maxSpeed - 2) * Time.deltaTime);

        if (isAttack)
        {
            float distance = Vector3.Distance(targetMonster.transform.position, player2.transform.position);
            if(Mathf.Abs(distance) < attackRange && attacking == false)
            {
                if (hitTag == "Monster")
                {
                    targetMonster = hit.collider.gameObject;
                    StartCoroutine(attack());
                }
                mousePos = player2.transform.position;

            }
        }
    }
    IEnumerator attack()
    {
        attacking = true;
        if (EquippedWeapons.weaponsName != "분필")
        {
            vStart = player2.transform.position;
            vEnd = targetMonster.transform.position;
            Vector3 v = vEnd - vStart;
            angle = Mathf.Atan2(v.y, v.x) * Mathf.Rad2Deg;
            angle -= 90;
            GameObject animGO = Instantiate(animPrefab, player2.transform);
            animGO.transform.Rotate(new Vector3(0, 0, angle));
            animGO.transform.Translate(Vector2.up * 1.5f);

        }
        yield return new WaitForSeconds(animTime); // 애니메이션 시간
        Monster monster = (Monster)targetMonster.GetComponent(typeof(Monster));
        if (EquippedWeapons.weaponsName == "분필")
        {
            GameObject chalkGO = Instantiate(chalk);
            chalkGO.transform.position = player2.transform.position;
            Chalk chalkGo = chalkGO.GetComponent<Chalk>();
            chalkGo.vEnd = targetMonster.transform.position;
        }
        else monster.hp -= weaponDamage;
        print("플레이어가 공격");
        if (monster.hp <= 0)
        {
            isAttack = false;
            targetMonster = null;
        }
        yield return new WaitForSeconds(attackDelay); // 공속
        attacking = false;
    }
}
