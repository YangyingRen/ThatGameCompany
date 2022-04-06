using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirForce : MonoBehaviour
{
    public Rigidbody Player;
    public bool isActive;
    public Vector3 Gravity;
    // Start is called before the first frame update
    void Start()
    {
    
        
    }

    // Update is called once per frame
    void Update()
    {
        Gravity=Physics.gravity;
        if(isActive==true){
        Physics.gravity=new Vector3(0,100f,0);
        }
        else{
        Physics.gravity=new Vector3(0,-9.8f,0);

        }
    }
    private void OnTriggerStay(Collider col){
        if(col.tag=="Player"){
            isActive=true;
        }
    }
     private void OnTriggerExit(Collider col){
        if(col.tag=="Player"){
            isActive=false;
        }
    }
}
