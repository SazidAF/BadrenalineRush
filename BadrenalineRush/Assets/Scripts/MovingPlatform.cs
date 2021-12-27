using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private int startingIndex;
    [SerializeField]
    private Transform[] points;
    private int index_;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = points[startingIndex].position;
    }

    // Update is called once per frame
    void Update()
    {
        movePlatform();
    }

    private void movePlatform()
    {
        if(Vector2.Distance(transform.position, points[index_].position) < .02f)
        {
            index_ += 1;
            if(index_ == points.Length)
            {
                index_ = 0;
            }
        }

        transform.position = Vector2.MoveTowards(transform.position, points[index_].position, speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.transform.SetParent(transform);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        collision.transform.SetParent(null);
    }
}
