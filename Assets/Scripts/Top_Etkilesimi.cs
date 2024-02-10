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
        //rastgele yatay hareket baþlatýyoruz topa saða sola
        top.velocity = new Vector2 (Random.Range(-yatayHiz,yatayHiz), top.velocity.y);
    }



    private void OnCollisionEnter2D(Collision2D temas)
    {
        if (temas.gameObject.tag == "Player")
        { 
            //yukarý aþaðý salýným hareketi yapar. yukarý harekete dikey hizi verir
            top.velocity = new Vector2(top.velocity.x,dikeyHiz);
        
        }
            
        if(temas.gameObject.tag == "SolDuvar")

        {
            //saða iter topu
            top.velocity = new Vector2(yatayHiz,top.velocity.y);
        }

        if (temas.gameObject.tag == "SaðDuvar")
        {
            //sola iter topu
            top.velocity = new Vector2(-yatayHiz, top.velocity.y);
        }
        if (temas.gameObject.tag == "UstDuvar")
        {
            //Aþaðý doðru kuvvet uygular
            top.velocity = new Vector2(top.velocity.x,-dikeyHiz);
        }
        
        if(temas.gameObject.tag == "Bitis")
        {
            yaziWin.text = "Malesef kaybettiniz. \n " +
         "Puaniniz: " +Win.skor + "\n Kirdiðiniz Blok : " + Win.kirilanBlok + "\n\n" +
         "Tekrar oynamak için bir tuþa basýnýz.";
            Time.timeScale = 0;
            Destroy(yaziObjesi);
            Destroy(playerObjesi);
            Destroy(topObjesi);
          
        }

    }

}
