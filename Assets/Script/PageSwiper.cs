using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PageSwiper : MonoBehaviour
{
    public Transform leftPosition;
    public Transform rightPosition;
    public float smoothSpeed = 5.0f;
    public GameObject objecttoswitch;

    private bool isMoving = false;
    private Vector3 targetPosition;
    private int state = 0;
    private int working = 0;

    private void Start()
    {
        transform.position = leftPosition.position;
        state = 1;
    }

    void Update()
    {
        if (Input.touchCount > 0 && !isMoving)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                Vector3 touchPosition = touch.position;
                if (touchPosition.x < Screen.width * 0.5f && state != 1)
                {
                    MoveCamera(leftPosition.position);
                    state = 1;

                }
                else if (touchPosition.x >= Screen.width * 0.5f && state != 2)
                {
                    MoveCamera(rightPosition.position);
                    state = 2;
                }
            }
        }
        if (isMoving)
        {
            transform.position = targetPosition;
            isMoving = false;
            if (working == 0)
            {
                objecttoswitch.SetActive(true);
                working = 1;
            }
            else
            {
                objecttoswitch.SetActive(false);
                working = 0;
            }
        }
    }

    private void MoveCamera(Vector3 target)
    {
        targetPosition = target;
        isMoving = true;
    }
}
