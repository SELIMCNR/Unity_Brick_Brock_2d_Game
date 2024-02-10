using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    // Start is called before the first frame update
   public void StartGame()
    {
        SceneManager.LoadSceneAsync(1);
    }

    // Update is called once per frame
 public void QuitGame()
    {
        Application.Quit();
    }

    public void YenidenOyna()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

}
