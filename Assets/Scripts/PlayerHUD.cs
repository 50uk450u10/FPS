using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerHUD : MonoBehaviour
{
    [SerializeField] Image healthBar;
    [SerializeField] TMP_Text currentAmmoText;
    [SerializeField] TMP_Text maxAmmoText;

    FPSController player;

    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<FPSController>();
    }

    public void UpdateCurrentAmmo(int AmmoCount)
    {
        currentAmmoText.text = AmmoCount.ToString();
    }

    public void UpdateMaxAmmo(int GunMaxAmmo)
    {
        maxAmmoText.text = GunMaxAmmo.ToString();
    }

    public void UpdateHealth()
    {
        healthBar.fillAmount = healthBar.fillAmount > 0 ? healthBar.fillAmount -= 0.1f : 0;
    }

    /*
     
     */
}
