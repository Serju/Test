using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    public Material mat2,mat3,mat4;
    private bool triggered=false;
    public GameObject prnt;

 void Update()
    {
    
    }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.name=="guide")
        {
            Debug.Log("Trigger");
            prnt.GetComponent<DrawLineUp>().getTriggered(this.gameObject);
            color(mat2);
            
        }
    }
    private void OnTriggerExit(Collider other) {
        if(other.gameObject.name=="guide")
        {
            Debug.Log("Out");
            color(mat3);
        }
    }

    public void color(Material mat) {
        this.GetComponent<Renderer>().material=mat;
        
    }
    
    public void finishedColor()
    {
      //   this.GetComponent<Renderer>().material=ma4;
    }
    public void setTrigger()
    {
        triggered=true;
    }
    public bool getTrigger()
    {
        return triggered;
    }
   
}
