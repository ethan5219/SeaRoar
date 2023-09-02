using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeletePlayerStat : MonoBehaviour
{
    public void Delete()
    {
        PlayerPrefs.DeleteAll();
    }
}
