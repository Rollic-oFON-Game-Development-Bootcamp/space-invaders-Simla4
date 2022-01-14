using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Transform playerRoot;
    [SerializeField] private Bullet bullet;

    [SerializeField] private float sidewaysMovementSensivity = 1.0f;
    [SerializeField] private float leftMovementLimitPos = -2.24f;
    [SerializeField] private float rightMovementLimitPos = 2.24f;
    [SerializeField] private bool isLaserActive = false;

    private Vector2 inputDrag;
    private Vector2 prevMousePos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MoveSideways();
        GetInput();
        Shoot();

    }

    private void MoveSideways()
    {
        var currentPos = playerRoot.localPosition;
        var dragPos = Vector3.right * inputDrag.x * sidewaysMovementSensivity;

        if (currentPos.x + dragPos.x < rightMovementLimitPos && currentPos.x + dragPos.x > leftMovementLimitPos)
        {
            playerRoot.localPosition += dragPos;
        }
    }

    private void GetInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            prevMousePos = Input.mousePosition;
        }
        if (Input.GetMouseButton(0))
        {
            var deltaMouse = (Vector2)Input.mousePosition - prevMousePos;
            inputDrag = deltaMouse;
            prevMousePos = Input.mousePosition;
        }
        else
        {
            inputDrag = Vector2.zero;
        }
    }

    private void Shoot() 
    {
        if(!isLaserActive)
        {
            if (Input.GetMouseButtonDown(1))
            {
                Instantiate(this.bullet, this.transform.position, Quaternion.identity);
                isLaserActive = false;
            }
        }
        
    }
}
