using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempleGroundAction : MonoBehaviour
{
    public bool[] count;
    public Animator animator;
    void Start()
    {
        count= new bool[4];
        for (int i =0;i<4;i++)
        {
            count[i]=false;
        }
    }


    void Update()
    {
        if(count[0]==true&&count[1]==true&&count[2]==true&&count[3]==true)
           animator.SetTrigger("activate");
    }


    public void newTrigger0()
    {
        count[0]=true;
    }

    public void removeTrigger0()
    {
        count[0]=false;
    }

    public void newTrigger1()
    {
        count[1]=true;
    }

    public void removeTrigger1()
    {
       count[1]=false;
    }

    public void newTrigger2()
    {
       count[2]=true;
    }

    public void removeTrigger2()
    {
       count[2]=false;
    }

    public void newTrigger3()
    {
        count[3]=true;
    }

    public void removeTrigger3()
    {
        count[3]=false;
    }
}
