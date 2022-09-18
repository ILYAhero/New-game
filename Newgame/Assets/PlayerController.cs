using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static event OnSwipeInput SwipeEvent;
    public delegate void OnSwipeInput(Vector2 directon);

    private Vector3 tapPosition;
    private Vector3 swipeDelta;

    private float deadZone = 80;

    private bool isSwiping;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                isSwiping = true;
                tapPosition = Input.GetTouch(0).position;
            }
            else if (Input.GetTouch(0).phase == TouchPhase.Canceled ||
                    Input.GetTouch(0).phase == TouchPhase.Ended)
            {
                ResetSwipe();
            }
            if (swipeDelta.magnitude > deadZone)
            {
                if (SwipeEvent != null)
                {
                    if (Mathf.Abs(swipeDelta.z) > Mathf.Abs(swipeDelta.x))
                        SwipeEvent(swipeDelta.z > 0 ? Vector3.forward : Vector3.back);
                    else
                        SwipeEvent(swipeDelta.x > 0 ? Vector3.left : Vector3.right);
                }
                ResetSwipe();
            }

        }
        CheckSwipe();
    }
    private void CheckSwipe()
    {
        swipeDelta = Vector2.zero;
        
        if (isSwiping)
        {
            if (Input.touchCount > 0)
                swipeDelta = Input.GetTouch(0).position - tapPosition;
        }
    }
    private void ResetSwipe()
    {
        isSwiping = false;
        tapPosition = Vector2.zero;
        swipeDelta = Vector2.zero;
    }
}
