using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class RifleBullet : MonoBehaviour
{
    GameObject player;
    public Rigidbody rb;
    float timer;
    public float timeBetweenShots = 3;
    // Start is called before the first frame update
    void Start()
    {
        player = this.gameObject;
        rb.AddForce(player.transform.right * 20, ForceMode.Impulse);
        timer = Time.timeSinceLevelLoad;
    }

    // Update is called once per frame
    void Update()
    {
        if (this.name == "Bullet(Clone)" && Time.timeSinceLevelLoad - timer > timeBetweenShots)
        {
            Destroy(this.gameObject);
        }
    }
}
