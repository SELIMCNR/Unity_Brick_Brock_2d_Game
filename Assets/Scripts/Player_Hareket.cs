using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Hareket : MonoBehaviour
{

    public float hiz;
    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKey(KeyCode.LeftArrow)) {

            //sola hareket
            transform.Translate(-hiz * Time.deltaTime,0f,0f); 
        
        }


        if (Input.GetKey(KeyCode.RightArrow))
        {
            //Saða hareket
            transform.Translate(hiz * Time.deltaTime,0f,0f);
        }
    }
}
