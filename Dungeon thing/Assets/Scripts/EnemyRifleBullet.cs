using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyRifleBullet : MonoBehaviour
{
    GameObject Enemy;
    public Rigidbody rb;
    float timer;
    public float timeBetweenShots = 3;
    // Start is called before the first frame update
    void Start()
    {
        Enemy = this.gameObject;
        rb.AddForce(Enemy.transform.right * 20, ForceMode.Impulse);
        timer = Time.timeSinceLevelLoad;
    }

    // Update is called once per frame
    void Update()
    {
        if (this.name == "Bullet (1)(Clone)" && Time.timeSinceLevelLoad - timer > timeBetweenShots)
        {
            Destroy(this.gameObject);
        }
    }
}
