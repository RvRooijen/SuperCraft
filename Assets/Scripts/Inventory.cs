using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public BlockData[] Slots = new BlockData[10];

    public void Add(BlockData newBlock)
    {
        Slots[0] = newBlock;
    }
}
