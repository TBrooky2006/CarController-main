using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public float waitTime;
    public GameObject enemy;
    public GameObject[] spawnpoints;
    bool active;

    // Start is called before the first frame update
    void Start()
    {
        active = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!active)
        {
            StartCoroutine(Spawn());
        }
    }

    IEnumerator Spawn()
    {
        active = true;

        int number = Random.Range(0, spawnpoints.Length);

        yield return new WaitForSeconds(waitTime);

        Instantiate(enemy, spawnpoints[number].transform.position, Quaternion.identity);

        active = false;
    }
}
