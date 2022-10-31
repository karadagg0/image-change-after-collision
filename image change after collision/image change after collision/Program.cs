using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Program : MonoBehaviour
{
    [SerializeField]
    private Sprite brokenImage;

    int count = 0;

    private void OnCollisionEnter2D(Collision2D target)
    {
        if (target.gameObject.tag == "Ball")
        {
            count++;


            if (count == 1)
            {
                GetComponent<SpriteRenderer>().sprite = brokenImage;
            }

            else if (count == 2)
            {
                Destroy(gameObject);
            }


        }




    }
}
