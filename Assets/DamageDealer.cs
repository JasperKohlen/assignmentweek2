using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    [SerializeField]
    public HealthBar healthBar;
    public void DealDamage()
    {
        float damage = Random.Range((float)0.07, (float)0.12);
        healthBar.SetHealth(damage);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
