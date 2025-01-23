using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CarCharacter : MonoBehaviour
{

    public int maxHealth;
    public Slider healthbar;

    public int currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    void Update()
    {
        healthbar.value = currentHealth;
        healthbar.maxValue = maxHealth;

        if (currentHealth <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
