using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Top_Etkilesimi : MonoBehaviour
{
    public Rigidbody2D top;
    public float yatayHiz, dikeyHiz;
    public GameObject yaziObjesi, playerObjesi,topObjesi;
    public Text puanYazisi, yaziWin;


    private void Start()
    {
        //rastgele yatay hareket ba�lat�yoruz topa sa�a sola
        top.velocity = new Vector2 (Random.Range(-yatayHiz,yatayHiz), top.velocity.y);
    }



    private void OnCollisionEnter2D(Collision2D temas)
    {
        if (temas.gameObject.tag == "Player")
        { 
            //yukar� a�a�� sal�n�m hareketi yapar. yukar� harekete dikey hizi verir
            top.velocity = new Vector2(top.velocity.x,dikeyHiz);
        
        }
            
        if(temas.gameObject.tag == "SolDuvar")

        {
            //sa�a iter topu
            top.velocity = new Vector2(yatayHiz,top.velocity.y);
        }

        if (temas.gameObject.tag == "Sa�Duvar")
        {
            //sola iter topu
            top.velocity = new Vector2(-yatayHiz, top.velocity.y);
        }
        if (temas.gameObject.tag == "UstDuvar")
        {
            //A�a�� do�ru kuvvet uygular
            top.velocity = new Vector2(top.velocity.x,-dikeyHiz);
        }
        
        if(temas.gameObject.tag == "Bitis")
        {
            yaziWin.text = "Malesef kaybettiniz. \n " +
         "Puaniniz: " +Win.skor + "\n Kirdi�iniz Blok : " + Win.kirilanBlok + "\n\n" +
         "Tekrar oynamak i�in bir tu�a bas�n�z.";
            Time.timeScale = 0;
            Destroy(yaziObjesi);
            Destroy(playerObjesi);
            Destroy(topObjesi);
          
        }

    }

}
