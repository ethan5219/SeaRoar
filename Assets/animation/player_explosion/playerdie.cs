using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerdie : MonoBehaviour
{
    void FixedUpdate() {
        Destroy(gameObject, 0.2f);
    }
}
