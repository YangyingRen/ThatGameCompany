using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public Transform Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider col){
        if(col.tag=="Player"){
           Player.parent=transform; 
        }
    }
    private void OnTriggerExit(Collider col){
        if(col.tag=="Player"){
            Player.parent=null;
            Player.localScale=new Vector3(1,1,1);
        }
    }
}
