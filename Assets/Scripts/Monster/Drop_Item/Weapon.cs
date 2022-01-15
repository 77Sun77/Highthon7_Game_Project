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
        if (name == "대걸레") EquippedWeapons.weaponsName = "대걸레";
        if (name == "책") EquippedWeapons.weaponsName = "책";
        if (name == "분필") EquippedWeapons.weaponsName = "분필";
        if (name == "나무배트") EquippedWeapons.weaponsName = "나무배트";
        if (name == "빗자루와 쓰레받이") EquippedWeapons.weaponsName = "빗자루와 쓰레받이"; 
    }
}
