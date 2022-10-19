using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class change2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public SpriteRenderer Sprite2;
    int clickcount2 = 0;
    public static int change2wait = 68;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown (KeyCode.Alpha2)){

            if(clickcount2 == 0){
            Sprite2.GetComponent<SpriteRenderer>().color = new Color32(0,0,250,255);
            change2wait = 48;
            }

            if(clickcount2 == 1){
            Sprite2.GetComponent<SpriteRenderer>().color = new Color32(8,245,39,255);
            change2wait = 62;
            }

            if(clickcount2 == 2){
             Sprite2.GetComponent<SpriteRenderer>().color = new Color32(246,248,6,255);
            change2wait = 51;
            }

            if(clickcount2 == 3){
            Sprite2.GetComponent<SpriteRenderer>().color = new Color32(253,16,16,255);
            change2wait = 78;
            }

            if(clickcount2 == 4){
            Sprite2.GetComponent<SpriteRenderer>().color = new Color32(167,37,168,255);
            change2wait = 68;
            clickcount2 = -1;
            }

            clickcount2++;
            Debug.Log(clickcount2);
        }
    }
}