using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public ObjectPool bulletpool;
    public float bulletSpeed = 10f;



    public void Update()
    {

    }
    void shoot()
    {
        GameObject bullet = bulletpool.GetObject();
        bullet.transform.position = transform.position;
        bullet.transform.rotation = transform.rotation;

        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        if(rb != null)
        {
            rb.linearVelocity = bullet.transform.forward * bulletSpeed;
        }
    }
    IEnumerator DeactivateBullet(GameObject bullet)
    {
        yield return new WaitForSeconds(2f);
        bulletpool.ReturnObject(bullet);
    }
}
