using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialChange : MonoBehaviour
{
    // Start is called before the first frame update

    public Material mat1, mat2;
    private bool change= false, trigegred=false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if(trigegred && Input.GetMouseButtonDown(0) && !change)
     {
         this.GetComponent<Renderer>().material=mat2;
         change=true;
     }

    }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.name=="guide")
        {
            trigegred=true;
        }
    }
    private void OnTriggerExit(Collider other) {
        if(other.gameObject.name=="guide")
        trigegred=false;
    }

}
