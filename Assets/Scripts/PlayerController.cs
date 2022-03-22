using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
  [SerializeField][Range(1.0f, 5.0f)] private float speed;
  [SerializeField][Range(80.0f, 200.0f)] private float currentRotateSpeed = 80.0f;

  // Start is called before the first frame update
  void Start()
  {

  }

  private void FixedUpdate()
  {

    if (Input.GetKey(KeyCode.LeftShift))
    {
      speed = 6.0f;
    } else {
      speed = 1.0f;
    }

    // 1.   transfor.Rotate();
    transform.Rotate(Vector3.up * currentRotateSpeed * Time.fixedDeltaTime * Input.GetAxis("Horizontal"));

    // 2.   transfor.Translate();
    transform.Translate(Vector3.forward * speed * Time.fixedDeltaTime * Input.GetAxis("Vertical"));
  }
}
