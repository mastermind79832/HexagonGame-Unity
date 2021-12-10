using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerScript : MonoBehaviour
{
    
    public float moveSpeed = 600f;

    float movement = 0f;

    // Update is called once per frame
    void Update()
    {   
       movement = Input.GetAxisRaw("Horizontal");

       if(Input.touchCount > 0)
       {
            Touch touch = Input.GetTouch(0);
            Vector3 touchPos = Camera.main.ScreenToWorldPoint(touch.position);
            touchPos.z = 0f;

            if(touch.phase == TouchPhase.Stationary)
            {
                if(touchPos.x > 0)
                    movement = 1f;
                else if (touchPos.x < 0)
                    movement = -1f;
            }
            if(touch.phase == TouchPhase.Ended)
                movement = 0f;
       }
        
    }


    private void FixedUpdate()
    {
        
        transform.RotateAround(Vector3.zero, Vector3.forward, Time.fixedDeltaTime * movement * -moveSpeed); 

    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        
        GameController.GameOver();
        //SceneManager.LoadScene(0);


    }
}
