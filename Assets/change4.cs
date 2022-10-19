using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class change4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public SpriteRenderer Sprite4;
    int clickcount4 = 0;
    // Update is called once per frame
    public static int change4wait = 62;
    void Update()
    {
        if(Input.GetKeyDown (KeyCode.Alpha4)){

            if(clickcount4 == 0){
            Sprite4.GetComponent<SpriteRenderer>().color = new Color32(246,248,6,255);
            change4wait = 51;
            }
            if(clickcount4 == 1){
            Sprite4.GetComponent<SpriteRenderer>().color = new Color32(253,16,16,255);
            change4wait = 78;
            }
            if(clickcount4 == 2){
            Sprite4.GetComponent<SpriteRenderer>().color = new Color32(167,37,168,255);
            change4wait = 68;
            }
            if(clickcount4 == 3){
            Sprite4.GetComponent<SpriteRenderer>().color = new Color32(0,0,250,255);
            change4wait = 48;
            }
            if(clickcount4 == 4){
            Sprite4.GetComponent<SpriteRenderer>().color = new Color32(8,245,39,255);
            change4wait = 62;
            clickcount4 = -1;
            }
            clickcount4++;
            Debug.Log(clickcount4);
        }
    }
}