using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public string name;
    void Start()
    {
        Destroy(gameObject, 5f);
    }

    void Update()
    {
        if (name == "��ɷ�") EquippedWeapons.weaponsName = "��ɷ�";
        if (name == "å") EquippedWeapons.weaponsName = "å";
        if (name == "����") EquippedWeapons.weaponsName = "����";
        if (name == "������Ʈ") EquippedWeapons.weaponsName = "������Ʈ";
        if (name == "���ڷ�� ��������") EquippedWeapons.weaponsName = "���ڷ�� ��������"; 
    }
}
