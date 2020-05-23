using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    private float rotSpeed;
    int direction;
    private void Start()
    {
        direction = Random.Range(1, 3);
        rotSpeed = Random.Range(100, 120);
    }
    // Update is called once per frame
    void Update()
    {
        //rotating the obj
        if (direction == 1)
            transform.Rotate(0, 0, rotSpeed * Time.deltaTime);
        if (direction == 2)
            transform.Rotate(0, 0, -rotSpeed * Time.deltaTime);
    }
}
