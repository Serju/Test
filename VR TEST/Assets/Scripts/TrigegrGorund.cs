using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigegrGorund : MonoBehaviour
{
    public Material mat1,mat2,mat3;
    private bool triggered=false;
    public GameObject gm;

    private void OnTriggerEnter(Collider other) {
          if(other.gameObject.name=="guide")
        {
            
            gm.GetComponent<GroundPuzzle>().getTriggered(this.gameObject);
            this.GetComponent<Renderer>().material=mat2;
            
        }
    }

    private void OnTriggerExit(Collider other) {
          if(other.gameObject.name=="guide")
        {
            this.GetComponent<Renderer>().material=mat1;
        }
    }

    public void setTrigger()
    {
       triggered=true;
        this.GetComponent<Renderer>().material=mat3;

    }
        
    public bool getTrigger()
    {
        return triggered;
    }

    public void resetTrigger()
    {
        triggered=false;
        this.GetComponent<Renderer>().material=mat1;
    }
    
    
}
