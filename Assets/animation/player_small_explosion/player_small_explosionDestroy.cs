using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_small_explosionDestroy : MonoBehaviour
{
    void FixedUpdate() {
        Destroy(gameObject, 0.2f);
    }
}
