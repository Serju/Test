using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempleGroundDetect1 : MonoBehaviour
{
    public GameObject parent;
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag=="puzzle")
        {
          //  Debug.Log("yay");
            parent.GetComponent<TempleGroundAction>().newTrigger1();
        }
    }

    private void OnTriggerExit(Collider other) {
        if(other.gameObject.tag=="puzzle")
        {
              //  Debug.Log("Nay");
                parent.GetComponent<TempleGroundAction>().removeTrigger1();
        }
    }
}
