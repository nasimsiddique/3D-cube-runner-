using System;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
  public Rigidbody rb;
  public float force = 1000f;
  public float speed = 10f;
  public float maxX;
  public float minX;

  // Start is called once before the first execution of Update after the MonoBehaviour is created
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {

    Vector3 playerPos = transform.position;
    playerPos.x = Mathf.Clamp(playerPos.x, minX, maxX);

    transform.position = playerPos;

    if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
      transform.position = transform.position + new Vector3(speed * Time.deltaTime, 0, 0);
    if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
      transform.position = transform.position - new Vector3(speed * Time.deltaTime, 0, 0);
  }
  private void FixedUpdate()
  {
    rb.AddForce(0, 0, 1000f * Time.deltaTime);
  }
}
