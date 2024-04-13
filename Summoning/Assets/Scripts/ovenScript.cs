using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ovenScript : MonoBehaviour
{

    public GameObject doorp;
    public GameObject x;
    public GameObject ouch;
    public GameObject why;

    public bool candles = false;

    public bool range = false;

    public bool recipeZone = false;

    public bool recipe = false;

    public GameObject e;
    public GameObject rp;

    public GameObject odd;
    public GameObject what;
    public GameObject kn;

    public SpriteRenderer ovin;
    public Sprite ofout;

    public SpriteRenderer e1;
    public Sprite e2;


    public SpriteRenderer r1;
    public Sprite r2;
    public Sprite r3;
    public Sprite r4;

    public Sprite r5;

    public gameState state;


    public GameObject s, s1, s2, s3, s4, s5, evil;

    public void addRecipe(){

        if(state.state >= 1){
            
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
        if(state.state == 5){
            r1.sprite = r5;
            StartCoroutine(endCoroutine());
        }
        e.SetActive(false);
        rp.SetActive(true);
        yield return new WaitForSeconds(2f);
        // Handle completion or continue with another coroutine
        rp.SetActive(false);
        e.SetActive(true);
        if(state.state == 3){
            StartCoroutine(oddCoroutine());
        }
        if(state.state == 4){
            StartCoroutine(whatCoroutine());
        }

        
        
        
    }

     IEnumerator oddCoroutine()
    {
        odd.SetActive(true);
        yield return new WaitForSeconds(2f);
        odd.SetActive(false);

    }

    IEnumerator whatCoroutine()
    {
        what.SetActive(true);
        yield return new WaitForSeconds(1f);
        StartCoroutine(what2Coroutine());
        what.SetActive(false);

    }

    IEnumerator what2Coroutine()
    {
        kn.SetActive(true);
        yield return new WaitForSeconds(2f);
        what.SetActive(false);
        kn.SetActive(false);

    }

    IEnumerator endCoroutine()
    {
        rp.SetActive(true);
        yield return new WaitForSeconds(2f);


        StartCoroutine(sCoroutine());
    }

    IEnumerator sCoroutine()
    {
        doorp.SetActive(false);
        Camera.main.transform.position = new Vector3(0f, 240f, -10f);
        s.SetActive(true);
        
        yield return new WaitForSeconds(0.5f);
        
        StartCoroutine(s1Coroutine());
    }
    IEnumerator s1Coroutine()
    {

        s1.SetActive(true);
        
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(s2Coroutine());
        
    }
    IEnumerator s2Coroutine()
    {s2.SetActive(true);
        
        yield return new WaitForSeconds(0.5f);

        StartCoroutine(s3Coroutine());
        
    }
    IEnumerator s3Coroutine()
    {s3.SetActive(true);
        
        yield return new WaitForSeconds(0.5f);

        StartCoroutine(s4Coroutine());
        
    }
    IEnumerator s4Coroutine()
    {
        s3.SetActive(true);
        
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(s5Coroutine());
        
    }
    IEnumerator s5Coroutine()
    {s5.SetActive(true);
        
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(s6Coroutine());

        
    }

    IEnumerator s6Coroutine()
    {evil.SetActive(true);
        
        yield return new WaitForSeconds(0.5f);
       
       SceneManager.LoadScene("EndScene");

        
    }


    public void ee(){
        e1.sprite = e2;
        ovin.sprite = ofout;
        
    }

}
