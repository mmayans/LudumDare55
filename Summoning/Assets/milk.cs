using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class milk : MonoBehaviour
{
    public bool range = false;

    public GameObject words;

    public GameObject warning;

    // Update is called once per frame
    void Update()
    {

        if(range){
             if (Input.GetKey(KeyCode.E)){
                    StartCoroutine(nopeCoroutine());
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
