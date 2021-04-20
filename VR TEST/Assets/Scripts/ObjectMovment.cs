using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovment : MonoBehaviour
{

    private bool clicked =false;
    private bool collided=false;
    public GameObject master;
    private Collider colider=null;

    private void Update() {
        if(collided && Input.GetMouseButtonDown(0)&& !clicked)
        {Debug.Log("Fraiere");
        
            colider.transform.parent=master.transform;
            clicked=true;
        }
        else if(collided&& Input.GetMouseButtonDown(0)&&clicked)
        {
            colider.transform.parent=null;
            clicked=false;
        }
        
    }

 private void OnTriggerEnter(Collider other) {
             

        if(other.gameObject.tag=="Movable")
        {
          
                Debug.Log("Colided!Enter");
                collided=true;
                Debug.Log(collided);
                other=colider;
              
        }
        if(collided)
        {
             Debug.Log("Parented");
        }
    }
    
    private void OnTriggerExit(Collider other) {
         if(other.gameObject.name=="AIM")
        {
          
                Debug.Log("Colided! Exit");
                collided=false;
                Debug.Log(collided);
                colider=null;
               
              
        }
        
    }
}
