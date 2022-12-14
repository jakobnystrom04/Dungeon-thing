using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rifle : MonoBehaviour
{
    public GameObject prefab;
    float timeSinceShot;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
           
        if (Time.timeSinceLevelLoad - timeSinceShot > 0.2f && Input.GetKey(KeyCode.Mouse0))
        {
            timeSinceShot = Time.timeSinceLevelLoad;
            Instantiate(prefab, transform.position, transform.rotation);
        }
    }
}
