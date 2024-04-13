using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startScreenScript : MonoBehaviour
{

    public SpriteRenderer spriteR;

    public SpriteRenderer logoRend;

    public Sprite sprite2;

    bool started = false;

    int count = 0;

    public string nextScene;

    public bool mixing = false;

    public Whisk whisk;

    
    public Sprite[] bg;

    public Sprite[] words;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(!mixing){
            if (Input.GetKeyDown(KeyCode.E)){
                mixing = true;
                if(!started){
                spriteR.sprite = sprite2;
                started = true;

                }

                //whisk stuff
                whisk.mix();

                count += 1;
            }

            
        }

        if(count >= 3 && !mixing){
                mixing = true;

                StartCoroutine(spillCoroutine0());
                //bowl spilling animation
 
            }

    }

    IEnumerator spillCoroutine0()
    {
        spriteR.sprite = bg[0];
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(spillCoroutine1());
    }

    IEnumerator spillCoroutine1()
    {
        spriteR.sprite = bg[1];
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(spillCoroutine2());
    }

    IEnumerator spillCoroutine2()
    {
        spriteR.sprite = bg[2];
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(spillCoroutine3());
    }

    IEnumerator spillCoroutine3()
    {
        spriteR.sprite = bg[3];
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(spillCoroutine4());
    }

    IEnumerator spillCoroutine4()
    {
        spriteR.sprite = bg[4];
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(spillCoroutine5());
    }

    IEnumerator spillCoroutine5()
    {
        spriteR.sprite = bg[5];
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(spillCoroutine6());
    }

    IEnumerator spillCoroutine6()
    {
        spriteR.sprite = bg[6];
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(spillCoroutine7());
    }

    IEnumerator spillCoroutine7()
    {
        spriteR.sprite = bg[7];
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(spillCoroutine8());
    }

    IEnumerator spillCoroutine8()
    {
        spriteR.sprite = bg[8];
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(spillCoroutine9());
    }

    IEnumerator spillCoroutine9()
    {
        spriteR.sprite = bg[9];
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(spillCoroutine10());
    }

    IEnumerator spillCoroutine10()
    {
        spriteR.sprite = bg[10];
        yield return new WaitForSeconds(0.5f);
        // Handle completion or continue with another coroutine
        StartCoroutine(logoCoroutine0());
    }
    

    IEnumerator logoCoroutine0()
{
    logoRend.sprite = words[0];
    yield return new WaitForSeconds(0.1f);
    StartCoroutine(logoCoroutine1());
}

IEnumerator logoCoroutine1()
{
    logoRend.sprite = words[1];
    yield return new WaitForSeconds(0.1f);
    StartCoroutine(logoCoroutine2());
}

IEnumerator logoCoroutine2()
{
    logoRend.sprite = words[2];
    yield return new WaitForSeconds(0.1f);
    StartCoroutine(logoCoroutine3());
}

IEnumerator logoCoroutine3()
{
    logoRend.sprite = words[3];
    yield return new WaitForSeconds(0.1f);
    StartCoroutine(logoCoroutine4());
}

IEnumerator logoCoroutine4()
{
    logoRend.sprite = words[4];
    yield return new WaitForSeconds(0.1f);
    StartCoroutine(logoCoroutine5());
}

IEnumerator logoCoroutine5()
{
    logoRend.sprite = words[5];
    yield return new WaitForSeconds(0.1f);
    StartCoroutine(logoCoroutine6());
}

IEnumerator logoCoroutine6()
{
    logoRend.sprite = words[6];
    yield return new WaitForSeconds(0.1f);
    StartCoroutine(logoCoroutine7());
}

IEnumerator logoCoroutine7()
{
    logoRend.sprite = words[7];
    yield return new WaitForSeconds(0.1f);
    StartCoroutine(logoCoroutine8());
}

IEnumerator logoCoroutine8()
{
    logoRend.sprite = words[8];
    yield return new WaitForSeconds(0.1f);
    StartCoroutine(logoCoroutine9());
}

IEnumerator logoCoroutine9()
{
    logoRend.sprite = words[9];
    yield return new WaitForSeconds(0.1f);
    StartCoroutine(logoCoroutine10());
}

IEnumerator logoCoroutine10()
{
    logoRend.sprite = words[10];
    yield return new WaitForSeconds(0.1f);
    StartCoroutine(logoCoroutine11());
}

IEnumerator logoCoroutine11()
{
    logoRend.sprite = words[11];
    yield return new WaitForSeconds(0.1f);
    StartCoroutine(logoCoroutine12());
}

IEnumerator logoCoroutine12()
{
    logoRend.sprite = words[12];
    yield return new WaitForSeconds(0.1f);
    StartCoroutine(logoCoroutine13());
}

IEnumerator logoCoroutine13()
{
    logoRend.sprite = words[13];
    yield return new WaitForSeconds(0.1f);
    StartCoroutine(logoCoroutine14());
}

IEnumerator logoCoroutine14()
{
    logoRend.sprite = words[14];
    yield return new WaitForSeconds(0.1f);
    StartCoroutine(logoCoroutine15());
}

IEnumerator logoCoroutine15()
{
    logoRend.sprite = words[15];
    yield return new WaitForSeconds(0.1f);
    StartCoroutine(logoCoroutine16());
}

IEnumerator logoCoroutine16()
{
    logoRend.sprite = words[16];
    yield return new WaitForSeconds(0.1f);
    StartCoroutine(logoCoroutine17());
}

IEnumerator logoCoroutine17()
{
    logoRend.sprite = words[17];
    yield return new WaitForSeconds(0.1f);
    StartCoroutine(logoCoroutine18());
}

IEnumerator logoCoroutine18()
{
    logoRend.sprite = words[18];
    yield return new WaitForSeconds(0.1f);
    StartCoroutine(logoCoroutine19());
}

IEnumerator logoCoroutine19()
{
    logoRend.sprite = words[19];
    yield return new WaitForSeconds(0.1f);
    StartCoroutine(logoCoroutine20());
}

IEnumerator logoCoroutine20()
{
    logoRend.sprite = words[20];
    yield return new WaitForSeconds(0.1f);
    StartCoroutine(logoCoroutine21());
}

IEnumerator logoCoroutine21()
{
    logoRend.sprite = words[21];
    yield return new WaitForSeconds(0.1f);
    StartCoroutine(logoCoroutine22());
}

IEnumerator logoCoroutine22()
{
    logoRend.sprite = words[22];
    yield return new WaitForSeconds(0.1f);
    StartCoroutine(logoCoroutine23());
}

IEnumerator logoCoroutine23()
{
    logoRend.sprite = words[23];
    yield return new WaitForSeconds(0.1f);
    // Handle completion or continue with another coroutine
    mixing = false;
    SceneManager.LoadScene(nextScene);
}







}
