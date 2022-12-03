using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret2 : Turret
{
    public int damage;
    public float interval;
    public GameObject bulletPrefabs;

    protected override void Start()
    {
        StartCoroutine(ShootDelay());
    }

    IEnumerator ShootDelay()
    {
        yield return new WaitForSeconds(interval);
        BulletPrefabs();
        StartCoroutine(ShootDelay());
    }

    void BulletPrefabs()
    {
        GameObject bulletItem = Instantiate(bulletPrefabs, transform);
        bulletItem.GetComponent<ShootItem>().Init(damage);
    }
}
