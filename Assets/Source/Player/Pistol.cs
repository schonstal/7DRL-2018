using UnityEngine;
using System.Collections;

//Prototype/Experimental, proceed with caution!!!
public class Pistol : MonoBehaviour {
  Animator animator;
  Rigidbody rigidbody;

  void Start() {
    animator = GetComponent<Animator>();
    Cursor.visible = false;

    rigidbody = GameObject.Find("Player").GetComponent<Rigidbody>();
  }
  
  void Update() {
    float movementSpeed = rigidbody.velocity.magnitude;
    
    transform.position = new Vector3(
      320/2 - 32 - Mathf.Sin(Time.time * 5) * movementSpeed / 5,
      180 - 60 + Mathf.Sin(Time.time * 10) * movementSpeed / 50,
      0
    );
  
    if(Input.GetMouseButtonDown(0) || Input.GetKeyDown("space")) {
      animator.Play("Shoot", -1, 0f);
    }
  }

  public void OnShootComplete() {
    animator.Play("Idle", -1, 0f);
  }
}
