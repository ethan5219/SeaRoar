using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour {
    public Transform player;
    public GameObject bulletPrefab;

    private Vector2 startingPoint;


    
    // Update is called once per frame
    void Update () {
        int i = 0;
        while(i < Input.touchCount){
            Touch t = Input.GetTouch(i);
            Vector2 touchPos = getTouchPosition(t.position); // * -1 for perspective cameras
            if(t.phase == TouchPhase.Began){
                if(t.position.x > Screen.width / 2){
                    shootBullet();
                }
            }
            ++i;
        }
    }
    Vector2 getTouchPosition(Vector2 touchPosition){
        return GetComponent<Camera>().ScreenToWorldPoint(new Vector3(touchPosition.x, touchPosition.y, transform.position.z));
    }

    void shootBullet(){
        GameObject b = Instantiate(bulletPrefab) as GameObject;
        b.transform.position = player.transform.position;
    }
}