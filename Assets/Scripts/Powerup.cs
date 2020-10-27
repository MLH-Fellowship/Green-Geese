using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    public Sprite Level1;

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y >= 10) {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = Level1;
        }

    }
}
