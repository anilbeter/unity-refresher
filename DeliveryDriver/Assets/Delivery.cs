using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
  bool hasPackage;

  void OnCollisionEnter2D(Collision2D other)
  {
    Debug.Log("Ouch!");
  }
  void OnTriggerEnter2D(Collider2D other)
  {
    if (other.tag == "Package")
    {
      Debug.Log("You got the package!");
      hasPackage = true;
    }
    if (other.tag == "Customer" && hasPackage)
    {
      Debug.Log("Package delivered!");
      hasPackage = false;
    }
  }
}
