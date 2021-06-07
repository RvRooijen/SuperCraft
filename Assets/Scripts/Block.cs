using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public enum BlockTypes
    {
        Sand,
        Dirt,
        Stone,
        Wood,
    }

    public BlockTypes BlockType;
    public float Health = 25;

    public void Damage(CharacterController characterController)
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
