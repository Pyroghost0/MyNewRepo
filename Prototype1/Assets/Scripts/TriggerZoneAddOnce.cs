/*
 * Caleb Kahn
 * Assignment 2
 * Adds score once player enters trigger zone
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZoneAddOnce : MonoBehaviour
{

    private bool triggered = false;

    private void OnTriggerEnter(Collider other) { 
        if (other.CompareTag("Player") && ! triggered) {
            triggered = true;
            ScoreManager.score++;
        }
    }
}
