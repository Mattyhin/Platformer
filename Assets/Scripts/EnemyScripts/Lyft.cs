using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lyft : MonoBehaviour
{
    public float speed = 3f;
    public bool goUp = true;

    public Transform up;
    public Transform down;
    
    void Update()
    {
        if (goUp)
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }

        if (transform.position.y > up.position.y)
        {
            goUp = false;
        }
        else if (transform.position.y < down.position.y)
        {
            goUp = true;
        }
    }
}
