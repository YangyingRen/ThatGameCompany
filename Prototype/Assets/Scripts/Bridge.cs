using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bridge : MonoBehaviour
{
    public Transform Windmile;
    public Material BridgeMaterial, TransparentMaterial;
    public int x;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        x=(int) Windmile.eulerAngles.x;
        if (x==90||x==180||x==270||x==0){
            gameObject.GetComponent<MeshCollider>().enabled=true;
            gameObject.GetComponent<MeshRenderer>().material=BridgeMaterial;
            
        }
        else{
            gameObject.GetComponent<MeshCollider>().enabled=false;
            gameObject.GetComponent<MeshRenderer>().material=TransparentMaterial;

        }
    }
}
