using System.Collections;
using System.Collections.Generic;
//using UnityEditor.Timeline;
using UnityEngine;

public class RepositionGround : MonoBehaviour
{
    BoxCollider2D box;
    float totallength;

    // Start is called before the first frame update
    void Start()
    {
        box = GetComponent<BoxCollider2D>();
        totallength = box.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= -totallength)
        {
            transform.position = (Vector2)transform.position + Vector2.right * totallength * 2f;
        }
    }
}
