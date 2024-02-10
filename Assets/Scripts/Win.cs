using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    public GameObject yaziObjesi, playerObjesi,topObjesi;
    // Start is called before the first frame update
    public Text yaziWin;
    public Transform Bloklar;
    int blokSayisi;
    public static int skor,kirilanBlok;
    public Text puanYazisi;
    void Start()
    {
        skor = 0;
        kirilanBlok = 0;
    }

    private void Update()
    {
        if(Time.timeScale == 0)
        {
            //Kaybedince yeniden ba�latma olay�.
            if (Input.anyKeyDown)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                Time.timeScale = 1;
            }
        }
        puanYazisi.text = "Puan : " + skor;
        blokSayisi = Bloklar.childCount; // bloklar i�indeki de�erleri tutar
        if (blokSayisi == 0)
        {
            yaziWin.text = "Tebrikler Kazandiniz \n " +
                "Puaniniz: "+skor+"\n Kirdi�iniz Blok : "+kirilanBlok+"\n\n" +
                "Tekrar oynamak i�in bir tu�a bas�n�z.";
            Time.timeScale = 0;
            Destroy(yaziObjesi);
            Destroy(playerObjesi);
            Destroy(topObjesi);
            if (Input.anyKeyDown)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                Time.timeScale = 1;
            }
        }
    }
}
