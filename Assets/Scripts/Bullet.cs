using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.GetComponent<Rigidbody>().AddForce(transform.forward * bulletSpeed, ForceMode.Impulse);
    }

    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);

        if (other.CompareTag("x"))
        {
            // run code here / dmg etc.
        }
    }
}
