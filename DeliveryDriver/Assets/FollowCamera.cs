using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
  [SerializeField] GameObject thingToFollow;
  // this things position (camera) should be the same as the car's position
  // so i should create REFERANCE

  void LateUpdate()
  {
    transform.position = thingToFollow.transform.position + new Vector3(0, 0, -10);
    // new Vector3 () kullandım cünkü z aksisinde -10 kadar gitmem lazım yoksa kamera yerin dibine giriyor
  }
}
