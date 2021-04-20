using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLineUp : MonoBehaviour
{
     // Start is called before the first frame update
    public int number; // count if pzl is complete
    public int distMax;
    private int count=-1;
    private bool onTrigger;
    private bool completed =false;

    public Animator animator;

    private GameObject imported;
   // public GameObject[] objectsArray=new GameObject[number];
    private Vector3 position1=new Vector3();
    private LineRenderer lr;
    void Start()
    {
     //  lr.startWidth(0.4f);
     lr=GetComponent<LineRenderer>();
     //lr.sharedMaterial.SetColor("_Color", Color.gray);
    lr.GetComponent<LineRenderer>().startColor=Color.green;
    }

    // Update is called once per frame
    void Update()
    {
       if(imported!=null && onTrigger &&Input.GetMouseButtonDown(0)&& !imported.GetComponent<TriggerScript>().getTrigger())
       {
           count++;
           position1=imported.transform.position;
           
               for(int i=count;i<number;i++)
               {
                   lr.SetPosition(i,position1);
               }
         
           // lr.SetPosition(count,position1);
            Debug.Log(position1+"\n"+count);
            imported.GetComponent<TriggerScript>().setTrigger();
            imported.GetComponent<TriggerScript>().finishedColor();
             
       }

       if(count == (number-1)&&!completed)
       {
           puzzleComplete();
       }
    }

    public void getTriggered(GameObject triggered)
    {
        imported=triggered;
       
      onTrigger=true;
     
    
    }
    public void removeTrigger()
    {
        imported=null;
        onTrigger=false;
    }

    public void puzzleComplete()
    {
        Debug.Log("Completed");
        completed=true;
        animator.SetTrigger("openDoor");

        for (int i=0;i<number;i++)
        {
            lr.SetPosition(i,position1);
        }
    }
}
