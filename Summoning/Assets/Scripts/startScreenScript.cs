using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startScreenScript : MonoBehaviour
{

    public SpriteRenderer spriteR;

    public Sprite sprite2;

    bool started = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.E)){
            if(!started){
             spriteR.sprite = sprite2;
             started = true;

            }

            count += 1;
        }
    }
}
