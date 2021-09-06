using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class BlockData
{
    public enum BlockTypes
    {
        None,
        Sand,
        Dirt,
        Stone,
        Wood,
    }

    public BlockTypes BlockType;
    public int Amount;
}
