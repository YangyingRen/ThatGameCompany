using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignalLight : MonoBehaviour
{
    public Material Active;
    public GameObject Goal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    if(Goal.GetComponent<MeshRenderer>().enabled==false){
        gameObject.GetComponent<MeshRenderer>().sharedMaterial=Active;
    }
    }
}
