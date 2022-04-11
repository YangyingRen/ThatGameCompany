using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMusic : MonoBehaviour
{
    public bool StopPlaying;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(StopPlaying==true){
           float M_volume=GetComponent<AudioSource>().volume;
           float New_volume=M_volume-0.005f;
           GetComponent<AudioSource>().volume=Mathf.Lerp(M_volume,New_volume,1);
           if(M_volume==0){
           GetComponent<AudioSource>().Stop();
           }

        }
        else{
           float M_volume=GetComponent<AudioSource>().volume;
           float New_volume=M_volume+0.005f;
           GetComponent<AudioSource>().volume=Mathf.Lerp(M_volume,New_volume,1);
        }
            
            

        
    }
    private void OnTriggerEnter(Collider col){
        if(col.tag=="Player"){
            StopPlaying=false;
            GetComponent<AudioSource>().Play();
        }    
    }
    private void OnTriggerExit(Collider col){
        if(col.tag=="Player"){
            StopPlaying=true;
         
        }
    }
}
