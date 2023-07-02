using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
  bool hasPackage;
  [SerializeField] float delayDestory = 1;
  [SerializeField] Color32 hasPackageColor = new Color32(204, 78, 136, 255);
  [SerializeField] Color32 noPackageColor = new Color32(255, 255, 255, 255);

  SpriteRenderer spriteRenderer;
  // SpriteRenderer ---> type

  void Start()
  {
    spriteRenderer = GetComponent<SpriteRenderer>();
  }


  void OnCollisionEnter2D(Collision2D other)
  {
    Debug.Log("Ouch!");
  }
  void OnTriggerEnter2D(Collider2D other)
  {
    if (other.tag == "Package" && !hasPackage)
    {
      spriteRenderer.color = hasPackageColor;
      Debug.Log("You got the package!");
      hasPackage = true;
      Destroy(other.gameObject, delayDestory);
    }
    if (other.tag == "Customer" && hasPackage)
    {
      spriteRenderer.color = noPackageColor;
      Debug.Log("Package delivered!");
      hasPackage = false;
    }
  }
}
