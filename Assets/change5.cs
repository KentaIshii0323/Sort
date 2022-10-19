using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class change5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public SpriteRenderer Sprite5;
    int clickcount5 = 0;
    // Update is called once per frame
    public static int change5wait = 51;
    void Update()
    {
        if(Input.GetKeyDown (KeyCode.Alpha5)){

            if(clickcount5 == 0){
            Sprite5.GetComponent<SpriteRenderer>().color = new Color32(253,16,16,255);
            change5wait = 78;
            }

            if(clickcount5 == 1){
             Sprite5.GetComponent<SpriteRenderer>().color = new Color32(167,37,168,255);
            change5wait = 68;
            }

            if(clickcount5 == 2){
            Sprite5.GetComponent<SpriteRenderer>().color = new Color32(0,0,250,255);
            change5wait = 48;
            }

            if(clickcount5 == 3){
            Sprite5.GetComponent<SpriteRenderer>().color = new Color32(8,245,39,255);
            change5wait = 62;
            }

            if(clickcount5 == 4){
            Sprite5.GetComponent<SpriteRenderer>().color = new Color32(246,248,6,255);
            change5wait = 51;
            clickcount5 = -1;
            }

            clickcount5++;
            Debug.Log(clickcount5);
        }
    }
}