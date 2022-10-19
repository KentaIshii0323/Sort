using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ChangeSquare2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public SpriteRenderer Sprite7;
    int clickcount7 = 0;
    public static int wait2 = 78;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown (KeyCode.UpArrow)){

            if(clickcount7 == 0){
            Sprite7.GetComponent<SpriteRenderer>().color = new Color32(167,37,168,255);
            wait2 = 68;
            }
            if(clickcount7 == 1){
            Sprite7.GetComponent<SpriteRenderer>().color = new Color32(0,0,250,255);
            wait2 = 48;
            }
            if(clickcount7 == 2){
            Sprite7.GetComponent<SpriteRenderer>().color = new Color32(8,245,39,255);
            wait2 = 62;
            }
            if(clickcount7 == 3){
            Sprite7.GetComponent<SpriteRenderer>().color = new Color32(246,248,6,255);
            wait2 = 51;
            }
            if(clickcount7 == 4){
            Sprite7.GetComponent<SpriteRenderer>().color = new Color32(253,16,16,255);
            clickcount7 = -1;
            wait2 = 78;
            }
            clickcount7++;
            Debug.Log(clickcount7);
            Debug.Log(wait2);
        }

        // if(Input.GetKeyDown (KeyCode.DownArrow)){

        //     if(clickcount7 == 0){
        //     Sprite7.GetComponent<SpriteRenderer>().color = new Color32(167,37,168,255);
        //     }
        //     if(clickcount7 == 1){
        //     Sprite7.GetComponent<SpriteRenderer>().color = new Color32(0,0,250,255);
        //     }
        //     if(clickcount7 == 2){
        //     Sprite7.GetComponent<SpriteRenderer>().color = new Color32(8,245,39,255);
        //     }
        //     if(clickcount7 == 3){
        //     Sprite7.GetComponent<SpriteRenderer>().color = new Color32(246,248,6,255);
        //     }
        //     if(clickcount7 == 4){
        //     Sprite7.GetComponent<SpriteRenderer>().color = new Color32(253,16,16,255);
        //     clickcount7 = 1;
        //     }
        //     clickcount7--;
        //     Debug.Log(clickcount7);
        // }
    }
}