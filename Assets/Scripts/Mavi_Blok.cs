using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mavi_Blok : MonoBehaviour
{
    public int blokSagligi;
    private MeshRenderer ressam;
    public Material mavi_kirik;
    public AudioSource blokSesi;


    private void Start()
    {
        ressam = GetComponent<MeshRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D temas)
    {
        if(temas.gameObject.tag == "Top")
        {
            blokSagligi--;  //blok saðlýðý azalt
            Win.skor += 20; //puaný artýr
            blokSesi.Play();// her temasta ses verir.
        }

        if(blokSagligi == 0)
        {
            Destroy(this.gameObject); //objeyi sil
            Win.kirilanBlok += 1;
        }

        if(blokSagligi == 1)
        {
            ressam.material = mavi_kirik; // can 1 olunca materiali deðiþtir
        }
    }
   
}
