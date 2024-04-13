using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endScript : MonoBehaviour
    {
        public Sprite[] words;
        
        public SpriteRenderer logoRend;

        void Start()
    {
        StartCoroutine(logoCoroutine0());
    }

            IEnumerator logoCoroutine0()
    {
        logoRend.sprite = words[0];
        yield return new WaitForSeconds(1.2f);
        StartCoroutine(logoCoroutine1());
    }

    IEnumerator logoCoroutine1()
    {
        logoRend.sprite = words[1];
        yield return new WaitForSeconds(0.8f);
        StartCoroutine(logoCoroutine2());
    }

    IEnumerator logoCoroutine2()
    {
        logoRend.sprite = words[2];
        yield return new WaitForSeconds(0.8f);
        StartCoroutine(logoCoroutine3());
    }

    IEnumerator logoCoroutine3()
    {
        logoRend.sprite = words[3];
        yield return new WaitForSeconds(1f);
        StartCoroutine(logoCoroutine4());
    }

    IEnumerator logoCoroutine4()
    {
        logoRend.sprite = words[4];
        yield return new WaitForSeconds(0.7f);
        StartCoroutine(logoCoroutine5());
    }

    IEnumerator logoCoroutine5()
    {
        logoRend.sprite = words[5];
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(logoCoroutine6());
    }

    IEnumerator logoCoroutine6()
    {
        logoRend.sprite = words[6];
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(logoCoroutine7());
    }

    IEnumerator logoCoroutine7()
    {
        logoRend.sprite = words[7];
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(logoCoroutine8());
        
    }

    IEnumerator logoCoroutine8()
    {
        logoRend.sprite = words[8];
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(logoCoroutine9());
        
    }
    IEnumerator logoCoroutine9()
    {
        logoRend.sprite = words[9];
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(logoCoroutine10());
        
    }
    IEnumerator logoCoroutine10()
    {
        logoRend.sprite = words[10];
        yield return new WaitForSeconds(1f);

        Application.Quit();
        
    }
}
