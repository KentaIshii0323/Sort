using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class change3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public SpriteRenderer Sprite3;
    int clickcount3 = 0; 
    // Update is called once per frame
     public static int change3wait = 48;

    void Update()
    {
        if(Input.GetKeyDown (KeyCode.Alpha3)){

            if(clickcount3 == 0){
            Sprite3.GetComponent<SpriteRenderer>().color = new Color32(8,245,39,255);
            change3wait = 62;
            }

            if(clickcount3 == 1){
            Sprite3.GetComponent<SpriteRenderer>().color = new Color32(246,248,6,255);
            change3wait = 51;
            }

            if(clickcount3 == 2){
            Sprite3.GetComponent<SpriteRenderer>().color = new Color32(253,16,16,255);
            change3wait = 78;
            }

            if(clickcount3 == 3){
            Sprite3.GetComponent<SpriteRenderer>().color = new Color32(167,37,168,255);
            change3wait = 68;
            }

            if(clickcount3 == 4){
            Sprite3.GetComponent<SpriteRenderer>().color = new Color32(0,0,250,255);
            change3wait = 48;
            clickcount3 = -1;
            }

            clickcount3++;
            Debug.Log(clickcount3);
        }
    }
}