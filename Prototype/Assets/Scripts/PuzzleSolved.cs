using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleSolved : MonoBehaviour
{
    public Material Active;
    public Animator anim;
    public int Goal;
    // Start is called before the first frame update
    void Start()
    {
    anim=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
    
    int len=transform.childCount;
    for(int i=0;i<len;i++){
       if( GameObject.Find("GameManager").GetComponent<GameManager>().Point==Goal){
           anim.SetBool("Rise",true);
       }
    }
        
    }

    public void ResetGoal(){
            GameObject.Find("GameManager").GetComponent<GameManager>().Point=0;
 
    }
    public void PlaySound(){
        GetComponent<AudioSource>().Play();
    }
}
