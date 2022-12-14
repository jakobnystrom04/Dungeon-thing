using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealth : MonoBehaviour
{
    public float playerHp = 5;
    GameObject bullethit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(playerHp <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("enemyBullet"))
        {
            if(other.gameObject != bullethit)
            {
                playerHp -= 1;
            }
            Destroy(other.gameObject);
            bullethit = other.gameObject;
        }
        
    }
}
