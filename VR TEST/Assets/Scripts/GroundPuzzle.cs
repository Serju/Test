using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundPuzzle : MonoBehaviour
{
        public int number; 
    private int count;
    public int distanceMax;
     private bool onTrigger;
    private bool completed =false;
    public Animator animator;
    private GameObject imported=null;
    private GameObject prev=null;
    private Vector3 position1=new Vector3();
    private LineRenderer lr;
    public GameObject[] arrayObjects;


    void Start() 
    {
     lr=GetComponent<LineRenderer>();
    lr.GetComponent<LineRenderer>().startColor=Color.green;
    // arrayObjects=new GameObject[number-1];
    count=-1;
    }

    void Update()
    {
        
       if(imported!=null && onTrigger &&Input.GetMouseButton(0)&&!imported.GetComponent<TrigegrGorund>().getTrigger()&&checkDistance(imported,prev))
       {
           count++;
           position1=imported.transform.position;
             for(int i=count;i<number;i++)
               {
                   lr.SetPosition(i,position1);
               }
            Debug.Log(position1+"\n"+count);
            imported.GetComponent<TrigegrGorund>().setTrigger();   
            prev=imported;          
       }
       if(count == (number-1)&&!completed)
       {
           puzzleComplete();
       }
       if(!Input.GetMouseButton(0)&&!completed)
       {
           resetPuzzle();
       }
    
    }

    public void getTriggered(GameObject triggered)
    {
        imported=triggered;
        if(count==-1)
           prev=triggered;
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
        animator.SetTrigger("TowerUp");
        for (int i=0;i<number;i++)
        {
            lr.SetPosition(i,position1);
        }
    }
    public void resetPuzzle()
    {
        for(int i=0;i<number;i++)
         {
         lr.SetPosition(i,new Vector3(100,100,100));
         arrayObjects[i].GetComponent<TrigegrGorund>().resetTrigger();
         }
         count=-1;
    }
   
   public bool checkDistance(GameObject a, GameObject b) {
       float distance=Vector3.Distance(a.transform.position, b.transform.position);
       Debug.Log(distance);
       if(distance<distanceMax)
       return true;
       else return false;
   }
}
//ToDo
/*
    - trebe sa fac distana limitata si sa mearga doar cu keep left click down =)
*/