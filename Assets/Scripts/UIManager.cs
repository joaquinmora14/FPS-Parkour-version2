using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI txtMoney;
    public TextMeshProUGUI SaludTxt;

    public void UpdateMoneyText(string money)
    {
        txtMoney.text = "$" + money;
    }

    public void UpdateHealthText(string health)
    {
        SaludTxt.text = "Salud: " + health;
    }


}
