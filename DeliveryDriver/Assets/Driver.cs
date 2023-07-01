using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
  [SerializeField] float steerSpeed = 1;
  [SerializeField] float moveSpeed = 0.5f;


  void Start()
  {

  }

  void Update()
  {
    float steerAmount = Input.GetAxis("Horizontal") * steerSpeed;
    float moveAmount = Input.GetAxis("Vertical") * moveSpeed;
    transform.Rotate(0, 0, -steerAmount);
    transform.Translate(0, moveAmount, 0);
  }
}
