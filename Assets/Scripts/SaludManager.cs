using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SaludManager : MonoBehaviour
{
    public float salud;
    public UIManager uiManager;

    void Start()
    {
        uiManager = FindObjectOfType<UIManager>();
    }

    public bool UpdateHealth(float amount)
    {
        if (salud + amount < 0)
        {
            Debug.Log("Te moriste");
            return false;

        }
        else
        {
            salud += amount;
            uiManager.UpdateHealthText(salud.ToString());
            return true;
        }

    }
}
