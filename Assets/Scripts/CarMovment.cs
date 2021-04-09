using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class CarMovment : NetworkBehaviour
{
    float rotationSpeed;
    float speed;

    Transform start;

    private void Awake()
    {
        rotationSpeed = 100;
        speed = 5;

        start = GameObject.Find("StartPosition").GetComponent<Transform>();

        GetComponent<MeshRenderer>().material.color = Changecolor.listOfColors[Changecolor.playerNumber++];

         
       
        /* Changecolor.players[Changecolor.playerNumber] = gameObject;*/
        /*לא קשור למשחק שלהו אבל שתבינו לאן אפשר לקחת את זה*/
        /*יש לנו גיימאובג'קט שאנו מכניסים לתוך*/
        /* ל ואז כל תכונה שהגדרתם אותו שחקן יש לנו שליטה מלאה עליו כי הוא נמצא אצלנו בתוך הסקריפט */
        /*אני יכול לשנות לו את הריגיד-בודי , ואת כל המאפיינים שרק נרצה*/

    }

    void Update()
    {
        if (!isLocalPlayer) return;
      
          /* if (isLocalPlayer)
                {
                    return;
                }*/

        float horizontal = Input.GetAxis("Horizontal");
        transform.Rotate(0, horizontal * rotationSpeed * Time.deltaTime, 0);//תזוזה על ציר וואי זה הימינה שמאלה

        float v = Input.GetAxis("Vertical");
        transform.Translate(0, 0, v * speed * Time.deltaTime);

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Plane")
        {
            transform.position = start.position;
        }
    }
}
