using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuideGoal : MonoBehaviour
{
    public Transform Goal;
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
            Goal.gameObject.SetActive(true);
            Destroy(gameObject);
        }
    }
}
