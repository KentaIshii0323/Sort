using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Finalresult : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // public SpriteRenderer Sprite1;
    // public SpriteRenderer Sprite2;
    // public SpriteRenderer Sprite3;
    // public SpriteRenderer Sprite4;
    // public SpriteRenderer Sprite5;



    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown (KeyCode.Return)){
           if(change1.change1wait == 48){
            if(change2.change2wait == 51){
                if(change3.change3wait == 62){
                    if(change4.change4wait == 68){
                        if(change5.change5wait == 78){
                            Debug.Log("seikai");
                        }
                    }
                }
            }
           }
           else{
            Debug.Log("fuseikai");
           }
    }
}
}