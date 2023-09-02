using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterLevel : MonoBehaviour
{
    public int EnterLevelIndex;
    public void LoadGame()
    {
        SceneManager.LoadScene(EnterLevelIndex);
    }
}
