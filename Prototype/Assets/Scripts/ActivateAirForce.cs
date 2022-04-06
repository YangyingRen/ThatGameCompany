using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateAirForce : MonoBehaviour
{
    public GameObject AirForce;
    public Transform DoneGoal;
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
            AirForce.SetActive(true);
            transform.parent=DoneGoal;
            gameObject.transform.GetChild(0).gameObject.SetActive(false);
            gameObject.GetComponent<SphereCollider>().enabled=false;
            gameObject.GetComponent<MeshRenderer>().enabled=false;
            gameObject.GetComponent<AudioSource>().Play();
        }
    }
}
