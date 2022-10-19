using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class change1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public SpriteRenderer Sprite8;
    int clickcount = 0;
    public static int change1wait = 78;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown (KeyCode.Alpha1)){

            if(clickcount == 0){
            Sprite8.GetComponent<SpriteRenderer>().color = new Color32(167,37,168,255);
            change1wait = 68;
            }

            if(clickcount == 1){
            Sprite8.GetComponent<SpriteRenderer>().color = new Color32(0,0,250,255);
            change1wait = 48;
            }

            if(clickcount == 2){
            Sprite8.GetComponent<SpriteRenderer>().color = new Color32(8,245,39,255);
            change1wait = 62;
            }

            if(clickcount == 3){
            Sprite8.GetComponent<SpriteRenderer>().color = new Color32(246,248,6,255);
            change1wait = 51;
            }

            if(clickcount == 4){
            Sprite8.GetComponent<SpriteRenderer>().color = new Color32(253,16,16,255);
            change1wait = 78;
            clickcount = -1;
            }

            clickcount++;
            Debug.Log(clickcount);
        }
    }
}