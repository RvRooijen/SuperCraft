using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public float Health = 500;

    public void Damage()
    {
        // -- is eentje omlaag
        // == is gelijk aan
        // != is niet gelijk aan
        Health--;

        if (Health == 0)
        {
            Destroy(gameObject);
        }
    }
}
