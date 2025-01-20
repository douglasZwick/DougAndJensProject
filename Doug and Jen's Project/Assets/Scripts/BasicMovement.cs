using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
  public float m_MovementSpeed = 5;
  public float m_MinX = -7.5f;
  public float m_MaxX = 7.5f;


  void Start()
  {

  }


  void Update()
  {
    var movementInput = Input.GetAxis("Horizontal");

    if (movementInput == 0) return;

    var dX = movementInput * m_MovementSpeed * Time.deltaTime;
    var oldPos = transform.position;
    var newPos = oldPos;
    var oldX = oldPos.x;
    newPos.x = Mathf.Clamp(oldX + dX, m_MinX, m_MaxX);

    transform.position = newPos;
  }
}
