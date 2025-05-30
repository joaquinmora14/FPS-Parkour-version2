using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    public float money;

    public void UpdateMoney(float amount)
    {
        if (money + amount < 0)
        {
            Debug.Log("Dinero Insuficiente");

        }
        else
        {
            money += amount;
        }
    }



        
    }