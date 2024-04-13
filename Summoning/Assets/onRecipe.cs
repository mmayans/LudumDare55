using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onRecipe : MonoBehaviour
{
    public gameState state;
    public ovenScript oven;

    public bool range = false;

    public GameObject words;

    public saltScript salt;

    // Update is called once per frame
    void Update()
    {
        if(range){
             if (Input.GetKey(KeyCode.E)){
                    StartCoroutine(selfdestructCoroutine());
             }
        }
        
    }

    IEnumerator selfdestructCoroutine(){

        salt.words = salt.e;

        oven.recipe = true;
        oven.ee();
        state.state = 1;
        yield return new WaitForSeconds(0.1f);
        Destroy(words);
        Destroy(gameObject);

    }
}
