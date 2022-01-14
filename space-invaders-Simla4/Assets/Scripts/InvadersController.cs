using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvadersController : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float down;
    [SerializeField] private float time;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("InvadersMove", time);
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag.Equals("Boundry"))
        {
            speed = -speed;
            transform.position = new Vector2(transform.position.x, transform.position.y - down);
        }
    }

    private void InvadersMove()
    {
        transform.Translate(speed, 0, 0);
    }
}
