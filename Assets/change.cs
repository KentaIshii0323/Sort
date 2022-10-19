using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class change : MonoBehaviour
{
    Vector3 targetPoint = Vector3.zero;

    GameObject clickedGameObject1;
    GameObject clickedGameObject2;
    GameObject clickedGameObject3;

    public SpriteRenderer Sprite1;
    public SpriteRenderer Sprite2;
    public SpriteRenderer Sprite3;
    public SpriteRenderer Sprite4;
    public SpriteRenderer Sprite5;
    public GameObject Square1;
    public GameObject Square2;
    public GameObject Square3;
    public GameObject Square4;
    public GameObject Square5;
    public Button Button1;
    int clickcount = 0;
    Color tempcolor;
    Color tempcolor1;
    void Start(){
        // Debug.Log("4");
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)){    
            // clickedGameObject1 = null;
            tempcolor =  Button1.GetComponent<Image>().color; //SquareÇ…êFÇÃèÓïÒÇÇ¢ÇÍÇÈ
            Debug.Log(tempcolor);
            Button1.GetComponent<Image>().color = new Color32(255,255,255,255);
            Sprite1.GetComponent<SpriteRenderer>().color = new Color32(255,255,255,255);
            // Square1.Getcomponent<Renderer> ().material.color = new Color(Random.value, Random.value, Random.value, 1.0f);
            
             if(clickcount == 0){
                 tempcolor1 = Sprite1.GetComponent<SpriteRenderer>().color; //SquareÇ…êFÇÃèÓïÒÇÇ¢ÇÍÇÈ
                //  tempcolor1 = Square1.GetComponent<Image>().color; //SquareÇ…êFÇÃèÓïÒÇÇ¢ÇÍÇÈ
                 Debug.Log(tempcolor1);
                 clickcount++;
             }

             if(clickcount == 1){
                Square1.GetComponent<SpriteRenderer>().material.color =  Square2.GetComponent<SpriteRenderer>().material.color; //
                Square2.GetComponent<SpriteRenderer>().material.color = tempcolor1;
                clickcount = 0;
                // Debug.Log("2");
            }

            
            //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //RaycastHit2D hit2d = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);

            //if (hit2d)
            //{
              //  clickedGameObject1 = hit2d.transform.gameObject;
            //}
            // Debug.Log("3");
        }

        //if (Input.GetMouseButtonDown(2)){ 
            //clickedGameObject2 = null;

            //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //RaycastHit2D hit2d = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);

            //if (hit2d)
            //{
                //clickedGameObject2 = hit2d.transform.gameObject;
            //}
            //Debug.Log("2");
        //}

        //if(clickedGameObject1 != null || clickedGameObject2 != null)
        //{
          //  clickedGameObject3 = clickedGameObject1;
            //clickedGameObject1 = clickedGameObject2;
            //clickedGameObject2 = clickedGameObject3;
            //Debug.Log(clickedGameObject1);
            //Debug.Log(clickedGameObject2);
            //Debug.Log(clickedGameObject3);
        //}
    }
}
