using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropItem : MonoBehaviour
{
   private Inventory _inventory; 
   private int item;
 
   private void Start()
   {
      _inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
   }

   private void FixedUpdate()
   {
      if (transform.childCount<=0)
      {
         _inventory.isFull[item] = false;
         Debug.Log("Item is not full");
      }
   }
}
