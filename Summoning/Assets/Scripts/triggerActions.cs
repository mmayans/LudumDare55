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
        
    }


    private void OnTriggerExit(Collider col)
    {
        if(col.tag == "oven"){
            oven.x.SetActive(false);
            oven.range = false;

        }

        if(col.tag == "recipeCollider"){
            oven.e.SetActive(false);
            oven.recipeZone = true;

        }
        
    }
}
