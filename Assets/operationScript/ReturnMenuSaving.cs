using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ReturnMenuSaving : MonoBehaviour
{
    public int nextSceneBuildIndex; 

    public void Start() {
    nextSceneBuildIndex = SceneManager.GetActiveScene().buildIndex + 1;
    }
    
   public void Load(){
   SceneManager.LoadScene("MainMenu");
    if (nextSceneBuildIndex > PlayerPrefs.GetInt("levelAt"))
    {
        PlayerPrefs.SetInt("levelAt", nextSceneBuildIndex);
    }
}
}