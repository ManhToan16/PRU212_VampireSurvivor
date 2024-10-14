using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneWeapon : Weapon
{
    // Start is called before the first frame update
    public EnemyDamager damager;
    private float spawnTime, spawnCounter;
    void Start()
    {
        SetStats();
    }

    // Update is called once per frame
    void Update()
    {
        if (statsUpdated == true)
        {
            statsUpdated = false;
            SetStats();
        }  
        spawnCounter-=Time.deltaTime;
        if (spawnCounter <= 0f)
        {
            spawnCounter = spawnTime;
            Instantiate(damager,damager.transform.position, Quaternion.identity,transform).gameObject.SetActive(true); 
        }
    }
    void SetStats()
    {
        damager.damageAmout = stats[weaponLevel].damage;
        damager.lifeTime = stats[weaponLevel].duration;
        damager.timeBetweenDamage = stats[weaponLevel].speed;
        damager.transform.localScale = Vector3.one* stats[weaponLevel].range;
        spawnTime= stats[weaponLevel].timeBetweenAttacks;
        spawnCounter = 0f;
    }
}