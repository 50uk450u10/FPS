using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoRefill : MonoBehaviour
{
    FPSController player = null;
    [SerializeField] int refill;

    private void OnTriggerEnter(Collider other)
    {
        player = other.gameObject.GetComponent<FPSController>();
        if(player != null)
        {
            player.onInteract += refillPlayerAmmo;
            Debug.Log("Penetrator Active");
        }
        Debug.Log("Teledildonics");
    }

    private void OnTriggerExit(Collider other)
    {
        player.onInteract -= refillPlayerAmmo;
        Debug.Log("Satisfied");
    }

    private void refillPlayerAmmo()
    {
        player.IncreaseAmmo(refill);
    }
}
