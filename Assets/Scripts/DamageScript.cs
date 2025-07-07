using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DamageScript : MonoBehaviour
{
    public float damage = 1;
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
                Destroy(gameObject); // Se destruye el objeto que hace daño si el jugador sigue vivo
            }
        }
    }

    void Update()
    {
        if (SaludManager.salud <= 0)
        {
            //Debug.Log("Me morí :( ");
            SceneManager.LoadScene("FPS-Parkour");
        }
    }

}