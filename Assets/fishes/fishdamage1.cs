using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class fishdamage1 : MonoBehaviour
{
    public GameObject playerSmallExplosion;
    public GameObject playerDie;
    public float healthReduction = 20f;

    private void OnTriggerEnter2D(Collider2D other){
        if(other.tag == "bullet")
     {
        Destroy(this.gameObject);
     }
        if(other.tag == "Player")
        {
            GameObject p = Instantiate(playerSmallExplosion) as GameObject;
            p.transform.position = transform.position;
            HealthBarScript.health -= healthReduction;
            Destroy(this.gameObject);
        }
        if(other.tag == "Player" && HealthBarScript.health <= 0){
            GameObject d = Instantiate(playerDie) as GameObject;
            d.transform.position = transform.position;
            Destroy(this.gameObject);
            Destroy(other.gameObject);

        }
    }
}
