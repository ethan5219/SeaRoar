using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explosion_destroy : MonoBehaviour
{
    void FixedUpdate() {
        Destroy(gameObject, 2f);
    }
}
