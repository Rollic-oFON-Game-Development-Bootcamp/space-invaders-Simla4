using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Bullet : MonoBehaviour
{
    [SerializeField] private Vector3 direction;

    public float speed;
    public bool isActive = true;
    private void Update()
    {
        this.transform.position += this.direction * this.speed * Time.deltaTime;
    }

    public enum GameState
    {
        Invader01 = 0,
        Invader02 = 1,
        Invader03 = 2,
        Mystery = 3
    }

    private GameState state;
    public GameState State
    {
        get { return state; }
        set { state = value; }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag.Equals("Invader"))
        {
            state = GameState.Invader01;
            Destroy(collider.gameObject);
            Destroy(gameObject);
        }
        else if(collider.gameObject.tag.Equals("Invader02"))
        {
            state = GameState.Invader02;
            Destroy(collider.gameObject);
            Destroy(gameObject);
        }
        else if(collider.gameObject.tag.Equals("Invader03"))
        {
            state = GameState.Invader03;
            Destroy(collider.gameObject);
            Destroy(gameObject);
        }
        else if(collider.gameObject.tag.Equals("Mystery"))
        {
            state = GameState.Mystery;
            Destroy(collider.gameObject);
            Destroy(gameObject);
        }
        else if(collider.gameObject.tag.Equals("Boundry"))
        {
            Destroy(gameObject);
        }
    }
}
