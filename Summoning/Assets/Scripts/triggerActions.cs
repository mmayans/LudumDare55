using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerActions : MonoBehaviour
{
    // Start is called before the first frame update

    public ovenScript oven;




    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider col)
    {
        if(col.tag == "oven"){
            oven.x.SetActive(true);
            oven.range = true;

        }

        if(col.tag == "recipeCollider"){
            oven.e.SetActive(true);
            oven.recipeZone = true;

        }

         if(col.tag == "door"){
            Door door = col.gameObject.GetComponent<Door>();

            transform.position = door.pos;
            Camera.main.transform.position = door.campos;
        }

        if(col.tag == "milk"){
            milk door = col.gameObject.GetComponent<milk>();

            door.range = true;
            door.words.SetActive(true);
        }

        if(col.tag == "recipe"){
            onRecipe door = col.gameObject.GetComponent<onRecipe>();

            door.range = true;
            door.words.SetActive(true);
        }

        if(col.tag == "salt"){
            saltScript door = col.gameObject.GetComponent<saltScript>();

            door.range = true;
            door.words.SetActive(true);
        }

        if(col.tag == "chocolate"){
            chocola door = col.gameObject.GetComponent<chocola>();

            door.range = true;
            door.words.SetActive(true);
        }

        if(col.tag == "candle"){
            candles door = col.gameObject.GetComponent<candles>();

            door.range = true;
            door.words.SetActive(true);
        }

        if(col.tag == "knife"){
            knife door = col.gameObject.GetComponent<knife>();

            door.range = true;
            door.words.SetActive(true);
        }
        
        
    }


    private void OnTriggerExit(Collider col)
    {
        if(col.tag == "oven"){
            oven.x.SetActive(false);
            oven.range = false;

        }

        if(col.tag == "recipeCollider"){
            oven.e.SetActive(false);
            oven.recipeZone = false;

        }

        if(col.tag == "milk"){
            milk door = col.gameObject.GetComponent<milk>();

            door.range = false;
            door.words.SetActive(false);
        }

        if(col.tag == "recipe"){
            onRecipe door = col.gameObject.GetComponent<onRecipe>();

            door.range = false;
            door.words.SetActive(false);
        }

        if(col.tag == "salt"){
            saltScript door = col.gameObject.GetComponent<saltScript>();

            door.range = false;
            door.words.SetActive(false);
        }

        if(col.tag == "chocolate"){
            chocola door = col.gameObject.GetComponent<chocola>();

            door.range = false;
            door.words.SetActive(false);
        }
        
        if(col.tag == "candle"){
            candles door = col.gameObject.GetComponent<candles>();

            door.range = false;
            door.words.SetActive(false);
        }

        if(col.tag == "knife"){
            knife door = col.gameObject.GetComponent<knife>();

            door.range = false;
            door.words.SetActive(false);
        }
    }
}
