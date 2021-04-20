using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTranslate : MonoBehaviour
{
    // Start is called before the first frame update

        public float speed;     
    public GameObject  end,player;
    public Rigidbody  rb;
    public bool toTranslate=false; 
    
   
    // Update is called once per frame
    void Update()
    {
        if(toTranslate)
        player.transform.position=Vector3.MoveTowards(player.transform.position, end.transform.position,2f*Time.deltaTime*speed);
        
    }

    public void setBool()
    {
        toTranslate=true;
        Debug.Log(toTranslate);
    }
    public void resetBool()
    {
        toTranslate=false;
    }
}
