using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObMiddleScript : MonoBehaviour

{
   public LogicScript logic;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame

   private void OnTriggerEnter2D(Collider2D collision)
   {
    if (collision.gameObject.layer == 3)
    {
       logic.addScore(1);

       print ("trigger flipped");
    }
   }
}
