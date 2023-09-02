using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetrySaving : MonoBehaviour
{
    public int nextSceneBuildIndex; 
    public int currentSceneBuildIndex;

    public void Start() {
    nextSceneBuildIndex = SceneManager.GetActiveScene().buildIndex + 1;
    }
    
   public void Load(){
   SceneManager.LoadScene(currentSceneBuildIndex);
    if (nextSceneBuildIndex > PlayerPrefs.GetInt("levelAt"))
    {
        PlayerPrefs.SetInt("levelAt", nextSceneBuildIndex);
    }
}
}
