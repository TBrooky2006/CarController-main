using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public int damage;

    public int currentHp;
    public int maxHp;
    GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        currentHp = maxHp;
        target = GameObject.Find("Car");    
    }

    // Update is called once per frame
    void Update()
    {

        gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>().destination = target.transform.position;

        if (currentHp <= 0)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameObject.FindGameObjectWithTag("Vehicle").gameObject.GetComponent<CarCharacter>().currentHealth -= damage;
            Destroy(gameObject);
        }
    }
}
