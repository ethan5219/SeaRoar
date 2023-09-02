using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorialFishDamage : MonoBehaviour
{
    public GameObject playerSmallExplosion;
    private void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "Player")
        {
            GameObject p = Instantiate(playerSmallExplosion) as GameObject;
            p.transform.position = transform.position;
            Destroy(this.gameObject);
            }
    }
}
