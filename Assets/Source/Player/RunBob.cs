using UnityEngine;
using System.Collections;

public class RunBob : MonoBehaviour {
  public float bobDamp;
  public float bobSpeed;

  Vector3 initialPosition;
  Rigidbody rigidbody;

  void Start() {
    initialPosition = Camera.main.transform.position;
    rigidbody = GetComponent<Rigidbody>();
  }

  void Update() {
    float movementSpeed = rigidbody.velocity.magnitude;

    Camera.main.transform.position = new Vector3(
      transform.position.x,
      initialPosition.y + Mathf.Sin(Time.time * bobSpeed) * movementSpeed / bobDamp,
      transform.position.z
    );
  }
}
