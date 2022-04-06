using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class Goal : MonoBehaviour
{
    public GameObject PostProcessing;
    public Transform DoneGoal;
    private Volume m_Volume;
    public int Child;
    // Start is called before the first frame update
    void Start()
    {
    m_Volume= PostProcessing.GetComponent<Volume>();
 
     
    }

    // Update is called once per frame
    void Update()
    {
    m_Volume.profile.TryGet<ColorAdjustments>(out var m_Saturation);
    Child=DoneGoal.childCount;
    m_Saturation.saturation.value=-100+DoneGoal.childCount*15;
    
        
    }

    private void OnTriggerEnter(Collider col){
        if(col.tag=="Player"){
            GameObject.Find("GameManager").GetComponent<GameManager>().Point+=1;
            transform.parent=DoneGoal;
            gameObject.transform.GetChild(0).gameObject.SetActive(false);
            gameObject.GetComponent<SphereCollider>().enabled=false;
            gameObject.GetComponent<MeshRenderer>().enabled=false;
            gameObject.GetComponent<AudioSource>().Play();
           
        }
    }
}
