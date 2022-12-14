using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float health = 10;
    public GameObject player;
    public float speed = 1;
    public float damage = 2;
    public bool shooter;
    float angle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }
        if (shooter)
        {
            Vector2 playerPos = player.transform.position;
            Vector2 objectPos = transform.position;
            playerPos.x = playerPos.x - objectPos.x;
            playerPos.y = playerPos.y - objectPos.y;
            angle = Mathf.Atan2(playerPos.y, playerPos.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
        }
        else
        {
            transform.position -= (transform.position - player.transform.position).normalized * speed * Time.deltaTime;
        }
        

        

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {
            health -= 2;
            Destroy(other.gameObject);
        }

        if (other.CompareTag("Player"))
        {
            player.GetComponent<playerHealth>().playerHp -= damage;
            Destroy(gameObject);
        }
    }


}
