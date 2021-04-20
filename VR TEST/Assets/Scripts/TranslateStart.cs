using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslateStart : MonoBehaviour
{
  public GameObject prnt;

   private void OnTriggerEnter(Collider other) {
       if(other.gameObject.name=="skeleton")
       {
          prnt.GetComponent<PlayerTranslate>().setBool();

       Debug.Log("translate");
       }
   }
}
