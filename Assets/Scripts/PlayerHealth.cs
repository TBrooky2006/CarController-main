using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public Image healthbar;

    public void UpdateHealth(float fraction)
    {
        healthbar.fillAmount = fraction;
    }
}
