using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuLoop : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private float movespeed = 1f;
    [SerializeField]
    private float offset;
    private Vector2 startPosition;
    private float newXposition;
    void Start()
    {
        startPosition = transform.position;
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        newXposition = Mathf.Repeat(Time.time * -movespeed, offset);

        transform.position = startPosition + Vector2.right * newXposition;
    }
}

