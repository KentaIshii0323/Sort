using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChangeSquare1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public SpriteRenderer Sprite6;
    int clickcount6 = 0;
    public static int wait1 = 78;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown (KeyCode.RightArrow)){

            if(clickcount6 == 0){
                Sprite6.GetComponent<SpriteRenderer>().color = new Color32(167,37,168,255);
                wait1 = 68;
            }
            if(clickcount6 == 1){
                Sprite6.GetComponent<SpriteRenderer>().color = new Color32(0,0,250,255);
                wait1 = 48;
            }
            if(clickcount6 == 2){
                Sprite6.GetComponent<SpriteRenderer>().color = new Color32(8,245,39,255);
                wait1 = 62;
            }
            if(clickcount6 == 3){
                Sprite6.GetComponent<SpriteRenderer>().color = new Color32(246,248,6,255);
                wait1 = 51;
            }
            if(clickcount6 == 4){
                Sprite6.GetComponent<SpriteRenderer>().color = new Color32(253,16,16,255);
                clickcount6 = -1;
                wait1 = 78;
            }
            clickcount6++;
            Debug.Log(clickcount6);
            Debug.Log(wait1);
        }
        // if(Input.GetKeyDown (KeyCode.LeftArrow)){

        //     if(clickcount6 == 0){
        //     Sprite6.GetComponent<SpriteRenderer>().color = new Color32(167,37,168,255);
        //     clickcount6 = 5;
        //     }
        //     if(clickcount6 == 1){
        //     Sprite6.GetComponent<SpriteRenderer>().color = new Color32(0,0,250,255);
        //     }
        //     if(clickcount6 == 2){
        //     Sprite6.GetComponent<SpriteRenderer>().color = new Color32(8,245,39,255);
        //     }
        //     if(clickcount6 == 3){
        //     Sprite6.GetComponent<SpriteRenderer>().color = new Color32(246,248,6,255);
        //     }
        //     if(clickcount6 == 4){
        //     Sprite6.GetComponent<SpriteRenderer>().color = new Color32(253,16,16,255);
        //     }
        //     clickcount6--;
        //     Debug.Log(clickcount6);
        // }
    }
}