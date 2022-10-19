using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Buttonmeasurement : MonoBehaviour
{
    // Start is called before the first frame update


    
    void Start()
    {
        // change = gameObject.GetComponent<SpriteRenderer>();
    }

    // public SpriteRenderer Sprite10;
    // public SpriteRenderer sprite11;

    public Button measurement;
    public Sprite  same;
    public Sprite biasright;
    public Sprite biasleft;
    public SpriteRenderer spriteRenderer;
    public static int count = 0;


    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown (KeyCode.Space)){
        if(ChangeSquare1.wait1 > ChangeSquare2.wait2){
            spriteRenderer.sprite = biasleft; 
            Debug.Log(1);
        }
        if(ChangeSquare1.wait1 == ChangeSquare2.wait2){
            spriteRenderer.sprite = same; 
            Debug.Log(2);
        }
        if(ChangeSquare1.wait1 < ChangeSquare2.wait2){
             spriteRenderer.sprite = biasright;
            Debug.Log(3);
        }
       } 
        count++;
    }
}
