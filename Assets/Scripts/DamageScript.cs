using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageScript : MonoBehaviour
{
    public float damage = 10;
    public SaludManager SaludManager;
   
    void Start()
    {
        SaludManager = FindObjectOfType<SaludManager>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (SaludManager.UpdateHealth(-damage))
            {
                Destroy(gameObject);
            }

        }
    }

}
