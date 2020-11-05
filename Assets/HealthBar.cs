using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Image ImgHealthBar;
    public GameObject player;
    private int min = 0;
    private float currentHealth = 1;

    public void SetHealth(float damage)
    {
        currentHealth = currentHealth - damage;
        if (currentHealth < min)
        {
            currentHealth = 0;
        }
        ImgHealthBar.transform.localScale = new Vector3(currentHealth, 1, 1);
    }

    private void Update()
    {
        if (currentHealth == 0)
        {
            Destroy(player);
        }
    }
}
