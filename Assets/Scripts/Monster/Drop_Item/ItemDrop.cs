using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDrop : MonoBehaviour
{
    [Header("Food")]
    public GameObject[] food;

    [Header("Weapon")]
    public GameObject[] weapon;


    public GameObject savePoint;
    void Start()
    {
        
    }
    
    public GameObject spawnMilk()
    {
        return Instantiate(food[0]);
    }
    public GameObject spawnChoco()
    {
        return Instantiate(food[1]);
    }
    public GameObject spawnIceCream()
    {
        return Instantiate(food[2]);
    }
    public GameObject spawnJelly()
    {
        return Instantiate(food[3]);
    }



    public GameObject spawnMop()
    {
        return Instantiate(weapon[0]);
    }
    public GameObject spawnBook()
    {
        return Instantiate(weapon[1]);
    }
    public GameObject spawnChalk()
    {
        return Instantiate(weapon[2]);
    }
    public GameObject spawnBase()
    {
        return Instantiate(weapon[3]);
    }
    public GameObject spawnBroomstick()
    {
        return Instantiate(weapon[4]);
    }


    public GameObject spawnSavePoint()
    {
        return Instantiate(savePoint);
    }
}
