using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaveBlockTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        LevelGenerator.sharedInstance.AddNewBlock();
        LevelGenerator.sharedInstance.RemoveOldBLock();
    }
    
}
