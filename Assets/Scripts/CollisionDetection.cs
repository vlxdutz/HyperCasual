using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    public GameController Controller;
    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Border")) {
            Controller.BorderTrigger();
        }
        else if(other.CompareTag("Inel")) {
            Controller.InelTrigger();
        }
        else if(other.CompareTag("Penalizare")) {
            Controller.PenalizariTrigger();
        }
    }
}
