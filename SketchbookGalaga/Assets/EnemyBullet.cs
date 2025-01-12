using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public Transform enemyGunEnd;
    public GameObject enemyBulletPrefab;

    void Start()
    {
        
    }
    void Update()
    {
        
    }
    void Shoot()
    {
        Instantiate(enemyBulletPrefab, enemyGunEnd.position, enemyGunEnd.rotation);
    }
}
