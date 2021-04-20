using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveScript : MonoBehaviour
{

    public GameObject tempParent;
    public Transform guide;

    private bool move=false,clicked=false;

    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<Rigidbody>().useGravity=true;
    }

    // Update is called once per frame
    void Update()
    {
     if(move && Input.GetMouseButtonDown(0)&&!clicked)
     {
        // this.GetComponent<Rigidbody>().useGravity=false;
         this.GetComponent<Rigidbody>().isKinematic=true;
         this.transform.position=guide.transform.position;
         this.transform.rotation=guide.transform.rotation;
         this.transform.parent=tempParent.transform;
         clicked=true;
         Debug.Log(clicked);
     }
     else
     if(move && Input.GetMouseButtonDown(0) && clicked)
     {
         this.GetComponent<Rigidbody>().useGravity=true;
         this.GetComponent<Rigidbody>().isKinematic=false;
         this.transform.parent=null;
         this.transform.position=guide.transform.position;
                 
         clicked=false;
     }

    }
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.name=="guide")
        { move=true;
           // Debug.Log("Fraiere");
        }

    }
    private void OnTriggerExit(Collider other) {
        if(other.gameObject.name=="guide")
        move=false;
    }
}
