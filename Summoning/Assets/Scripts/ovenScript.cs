using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ovenScript : MonoBehaviour
{
    public GameObject x;
    public GameObject ouch;
    public GameObject why;

    public bool candles = false;

    public bool range = false;

    public bool recipeZone = false;

    public bool recipe = false;

    public GameObject e;
    public GameObject rp;

    public SpriteRenderer ovin;
    public Sprite ofout;

    public SpriteRenderer e1;
    public Sprite e2;


    public SpriteRenderer r1;
    public Sprite r2;
    public Sprite r3;
    public Sprite r4;

    public gameState state;

    public void addRecipe(){

        if(state.state >= 1){
            ovin.sprite = ofout;
        }

        if(state.state == 2){

            r1.sprite = r2;
        }
        if(state.state == 3){

            r1.sprite = r3;
        }

        if(state.state == 4){

            r1.sprite = r4;
        }

        
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(range){
            if(!candles){
                if (Input.GetKey(KeyCode.X)){
                    StartCoroutine(ouchCoroutine());
                }
            }
            else{
                //candle logic
            }
        }

        if(recipeZone){
                if(recipe){
                    if (Input.GetKey(KeyCode.E)){
                    StartCoroutine(recipeCoroutine());
                }
            }
        }
        
    }

    IEnumerator ouchCoroutine()
    {
        ouch.SetActive(true);
        yield return new WaitForSeconds(1f);
        // Handle completion or continue with another coroutine
        StartCoroutine(whyCoroutine());
    }

    IEnumerator whyCoroutine()
    {
        why.SetActive(true);
        yield return new WaitForSeconds(1f);
        // Handle completion or continue with another coroutine
        why.SetActive(false);
        ouch.SetActive(false);
    }


    IEnumerator recipeCoroutine()
    {
        e.SetActive(false);
        rp.SetActive(true);
        yield return new WaitForSeconds(2f);
        // Handle completion or continue with another coroutine
        rp.SetActive(false);
        e.SetActive(true);
        
    }

    public void ee(){
        e1.sprite = e2;
        
    }

}
