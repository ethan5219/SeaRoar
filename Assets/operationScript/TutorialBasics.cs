using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialBasics : MonoBehaviour
{
    [SerializeField] GameObject TutorialShoot;
    [SerializeField] GameObject introduction;
public void Intro()
{
    introduction.SetActive(true);
    TutorialShoot.SetActive(false);
}
}
