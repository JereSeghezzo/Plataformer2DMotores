using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGround : MonoBehaviour
{
 public static bool IsGrounded;

 void OnTriggerEnter2D(Collider2D col)
 {
     if(col.gameObject.CompareTag("Floor"))
     {
      IsGrounded = true;
     }
 }

  void OnTriggerExit2D(Collider2D col)
 {
  IsGrounded = false;
 }
}
