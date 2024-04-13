using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chocola : MonoBehaviour
{
     public bool range = false;

    public GameObject words;

    public GameObject warning;

    public gameState state;

    public GameObject e;

    public ovenScript oven;

    public candles choc;

    // Update is called once per frame
    void Update()
    {

        if(range){
             if (Input.GetKey(KeyCode.E)){
                if(state.state == 2){
                    state.state = 3;
                    oven.addRecipe();

                    choc.words = choc.e;

                    
                    Destroy(words);
                    Destroy(warning);
                    Destroy(e);
                    Destroy(gameObject);
                }
                else{
                    StartCoroutine(nopeCoroutine());
                    }
                }
        }
        
    }


     IEnumerator nopeCoroutine()
    {
        warning.SetActive(true);
        yield return new WaitForSeconds(1f);
        // Handle completion or continue with another coroutine
        warning.SetActive(false);
    }
}
