using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    
    public Transform firePoint;
    public GameObject projectilePrefab;

    public float projectileForce = 2f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")){
            shoot();
        }
    }

    void shoot(){
        GameObject projectile = Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = projectile.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * projectileForce, ForceMode2D.Impulse);
    }
}
