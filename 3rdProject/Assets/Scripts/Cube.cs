using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    bool isleft;
    Vector2 pos;
    Vector2 pos1;
    float speed = 2;
    // Start is called before the first frame update
    void Start()
    {
        pos = new Vector2(-1.4f, this.transform.position.y);
        pos1 = new Vector2(1.4f, this.transform.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        if (isleft)
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        else
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        if (this.transform.position.x <= -1.4f)
        {
            isleft = true;
        }
        if (this.transform.position.x >= 1.4f)
        {
            isleft = false;
        }

    }
}
