using UnityEngine;
using System.Collections;

public class BillboardBehavior : MonoBehaviour {
  public Transform cameraTransform;

  void Start() {
    if (cameraTransform == null) {
      cameraTransform = Camera.main.transform;
    }
  }

  void LateUpdate() {
    this.transform.forward = cameraTransform.forward;
  }
}
