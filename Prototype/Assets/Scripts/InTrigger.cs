using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InTrigger : MonoBehaviour
{
    public GameObject AirForce;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider col){
        if(col.tag=="Player"){
           AirForce.GetComponent<AirForce>().enabled=true;
        }
    }
    private void OnTriggerExit(Collider col){
        if(col.tag=="Player"){
            AirForce.GetComponent<AirForce>().enabled=false;
        }
    }
}
