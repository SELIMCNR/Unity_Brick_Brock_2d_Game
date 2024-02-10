using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yesil_Blok : MonoBehaviour
{
    public int blokSagligi;
    public AudioSource blokSesi;

    private void OnCollisionEnter2D(Collision2D temas)
    {
        if(temas.gameObject.tag == "Top")
        {
            blokSagligi--;  //blok sa�l��� azalt
            Win.skor += 10; //puan� art�r
            blokSesi.Play(); // her temasta ses verir.
        }

        if(blokSagligi == 0)
        {
            Destroy(this.gameObject); //objeyi sil
            Win.kirilanBlok += 1; //blok say�s� al�n�yor
        }
    }
}
