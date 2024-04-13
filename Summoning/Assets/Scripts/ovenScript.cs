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
        yield return new WaitForSeconds(5f);
        // Handle completion or continue with another coroutine
        rp.SetActive(false);
        e.SetActive(true);
        
    }

}
