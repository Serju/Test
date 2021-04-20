using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempleGroundDetect2 : MonoBehaviour
{
     public GameObject parent;
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag=="puzzle")
        {
          //  Debug.Log("yay");
            parent.GetComponent<TempleGroundAction>().newTrigger2();
        }
    }

    private void OnTriggerExit(Collider other) {
        if(other.gameObject.tag=="puzzle")
        {
              //  Debug.Log("Nay");
                parent.GetComponent<TempleGroundAction>().removeTrigger2();
        }
    }
}
