using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stoveTopScript : MonoBehaviour
{

    public ovenScript oven;

    private void OnTriggerEnter(Collider other)
    {
        print("tets");
        oven.range = true;
        oven.x.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        oven.range = false;
        
        oven.x.SetActive(false);
    }
}
