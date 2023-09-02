using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class NextLevel : MonoBehaviour
{
    public int nextSceneBuildIndex; 

    public void Start() {
    nextSceneBuildIndex = SceneManager.GetActiveScene().buildIndex + 1;
    }
    
   public void Load(){
   SceneManager.LoadScene(nextSceneBuildIndex);
    if (nextSceneBuildIndex > PlayerPrefs.GetInt("levelAt"))
    {
        PlayerPrefs.SetInt("levelAt", nextSceneBuildIndex);
    }
}
}


