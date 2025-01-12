using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 1.5f;

    public Transform playerTransform;

    public float fireRate = 0.1f;
    private float timeSinceLastAction = 0f;

    public GameObject enemybulletPrefab;
    public Transform enemyGunEnd;
    void Start()
    {
        GameObject playerGameObject = GameObject.Find("Player");
        playerTransform = playerGameObject.transform;
    }

    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            Debug.Log("Hit");
            Destroy(gameObject);
        }
    }
    void Shoot()
    {
        timeSinceLastAction += Time.deltaTime;

        if (timeSinceLastAction >= fireRate)
        {
            Instantiate(enemybulletPrefab, enemyGunEnd.position, Quaternion.identity);
            timeSinceLastAction = 0;
        }
    }
}