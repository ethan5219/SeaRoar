using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryGame : MonoBehaviour
{
    public int currentSceneBuildIndex; 
    public void LoadGame(){
        SceneManager.LoadScene(currentSceneBuildIndex);
    }
}
