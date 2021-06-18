using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonMovement : MonoBehaviour
{
    public float movementRatio = 10f;
 
    void FixedUpdate()
    {
        if(transform.position.x < 6.4 && transform.position.x > -6.4){
            if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)){
                transform.Translate(movementRatio * Vector3.left * Time.deltaTime);
                Debug.Log("left");
            }
            if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)){
                transform.Translate(movementRatio * Vector3.right * Time.deltaTime);
                Debug.Log("right");
            }
        }
        else if(transform.position.x >= 6.4) {
            if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)){
                transform.Translate(movementRatio * Vector3.left * Time.deltaTime);
                Debug.Log("left");
            }
        }
        else {
            if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)){
                transform.Translate(movementRatio * Vector3.right * Time.deltaTime);
                Debug.Log("right");
            }
        }
    }
}
