using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knife : MonoBehaviour
{
    // Start is called before the first frame update
   public bool range = false;

    public GameObject words;

    public GameObject warning;

    public gameState state;

    public GameObject e;

    public ovenScript oven;

    //public knife choc;

    // Update is called once per frame
    void Update()
    {

        if(range){
             if (Input.GetKey(KeyCode.E)){
                if(state.state == 4){
                    state.state = 5;
                    oven.addRecipe();

                   // choc.words = choc.e;

                    
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
