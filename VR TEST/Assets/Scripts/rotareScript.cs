using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotareScript : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate (0,0,50*Time.deltaTime);
    }
}
