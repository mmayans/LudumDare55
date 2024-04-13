using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Whisk : MonoBehaviour
{
    public SpriteRenderer spriteR;

    public startScreenScript start;

    public Sprite m;

    public Sprite gross;

    bool fresh = true;


    bool mixing = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

           

            

        

        
    }



    public void mix(){

        mixing = true;

        StartCoroutine(lerpCoroutine0());
            
        

    }

    IEnumerator lerpCoroutine0(){

        transform.position = new Vector3(0f, 3f, 50);

        yield return new WaitForSeconds(0.5f);

        StartCoroutine(lerpCoroutine());
    }


     IEnumerator lerpCoroutine()
    {

       
        transform.position = new Vector3(0f, 3f, 25);

        yield return new WaitForSeconds(0.5f);

        spriteR.sprite = m;

        
        StartCoroutine(lerpCoroutine2());

    }


    IEnumerator lerpCoroutine2(){
        
        transform.position = new Vector3(-22f, 3f, 14);

        yield return new WaitForSeconds(0.5f);

        StartCoroutine(lerpCoroutine3());

    }


    IEnumerator lerpCoroutine3(){
        transform.position = new Vector3(0f, 3f, 0);

        yield return new WaitForSeconds(0.5f);

        StartCoroutine(lerpCoroutine4());

       }


    IEnumerator lerpCoroutine4(){

        transform.position = new Vector3(13f, 3f, 14);

        yield return new WaitForSeconds(0.5f);

        StartCoroutine(lerpCoroutine5());
    }

    IEnumerator lerpCoroutine5(){
    
        transform.position = new Vector3(0f, 3f, 25);
        spriteR.sprite = gross;

        yield return new WaitForSeconds(0.5f);

        StartCoroutine(lerpCoroutine6());
    }

    IEnumerator lerpCoroutine6(){

        transform.position = new Vector3(0f, 3f, 50);

        yield return new WaitForSeconds(0.5f);

        StartCoroutine(lerpCoroutine7());
    }

    IEnumerator lerpCoroutine7(){

        transform.position = new Vector3(0f, 3f, 100);

        yield return new WaitForSeconds(0.5f);

        mixing = false;

        start.mixing = false;
    }



}

