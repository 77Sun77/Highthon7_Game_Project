using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
    public GameObject targetMonster;
    bool isAttack; // ���� �� �� �ִ°�
    bool attacking; // ���� ���� �� �ΰ�
    public int maxHp;
    public int player2Hp = 10;
    public Text HpBar;
    string Player2HpSee;
    public GameObject chalk; // ����
    public static int skillPoint = 100; // ��ų����Ʈ
    public static float animTime; // �ִϸ��̼� ���� �ð�
    public static float attackDelay; // ����
    public static int weaponDamage; // ������
    public static float attackRange; // ����

    public static GameObject animPrefab;
    public static GameObject shieldPrefab;
    Vector3 vStart, vEnd;
    float angle;

    EquippedWeapons e1;

    SpriteRenderer player2Sprite;
    int rotate;
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

        e1 = GetComponent<EquippedWeapons>();

        player2Sprite = player2.GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        Player2HpSee = player2Hp.ToString();
        HpBar.text = "HP:" + Player2HpSee;
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

            if(mousePos.x > player2.transform.position.x) player2Sprite.flipX = false;
            else player2Sprite.flipX = true;
        }
        if (Input.GetMouseButtonDown(1))
        {
            if(skillPoint >= 100)
            {
                skillPoint -= 100;
                e1.skill();
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

        float wheelInput = Input.GetAxis("Mouse ScrollWheel");
        
        if (wheelInput > 0 && EquippedWeapons.weaponsName == "���ڷ�� ��������")
        {
            GameObject shieldGO = Instantiate(shieldPrefab, player2.transform);
            Shield shield = shieldGO.GetComponent<Shield>();
            shield.hp = player2Hp;
        }

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
        if (EquippedWeapons.weaponsName != "����")
        {
            vStart = player2.transform.position;
            vEnd = targetMonster.transform.position;
            Vector3 v = vEnd - vStart;
            angle = Mathf.Atan2(v.y, v.x) * Mathf.Rad2Deg;
            angle -= 90;
            GameObject animGO = Instantiate(animPrefab, player2.transform);
            animGO.transform.Rotate(new Vector3(0, 0, angle));
            animGO.transform.Translate(Vector2.up * 1.5f);
            Destroy(animGO, 2f);
        }
        yield return new WaitForSeconds(animTime); // �ִϸ��̼� �ð�
        Monster monster = (Monster)targetMonster.GetComponent(typeof(Monster));
        if (EquippedWeapons.weaponsName == "����")
        {
            GameObject chalkGO = Instantiate(chalk);
            chalkGO.transform.position = player2.transform.position;
            Chalk chalkGo = chalkGO.GetComponent<Chalk>();
            chalkGo.vEnd = targetMonster.transform.position;
        }
        else
        {
            monster.hp -= weaponDamage;
            skillPoint += 5;
        }
        print("�÷��̾ ����");
        if (monster.hp <= 0)
        {
            isAttack = false;
            targetMonster = null;
        }
        yield return new WaitForSeconds(attackDelay); // ����
        attacking = false;
    }
}
