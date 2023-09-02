using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterLevel1 : MonoBehaviour
{
    public void LoadGame(){
        SceneManager.LoadScene("Level 1");
    }
}
