using UnityEngine;

public class MouseLook : MonoBehaviour
{
  public float sensitivity = 2f;
  public float clampInDegrees = 180f;
  public float smoothing = 3f;

  Quaternion rotation;

  Vector2 mousePosition;
  Vector2 smoothMouse;
  Vector2 targetDirection;

  void Start() {
    targetDirection = transform.localRotation.eulerAngles;
    Cursor.lockState = CursorLockMode.Locked;
  }

  void Update() {
    Quaternion targetOrientation = Quaternion.Euler(targetDirection);

    Vector2 mouseDelta = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));
    mouseDelta = Vector2.Scale(mouseDelta, new Vector2(sensitivity * smoothing, sensitivity * smoothing));

    smoothMouse.x = Mathf.Lerp(smoothMouse.x, mouseDelta.x, 1f / smoothing);
    smoothMouse.y = Mathf.Lerp(smoothMouse.y, mouseDelta.y, 1f / smoothing);

    mousePosition += smoothMouse;

    if (clampInDegrees < 360)
      mousePosition.y = Mathf.Clamp(mousePosition.y, -clampInDegrees * 0.5f, 0f);

    transform.localRotation = targetOrientation;

    var yRotation = Quaternion.AngleAxis(mousePosition.x, transform.InverseTransformDirection(Vector3.up));
    transform.localRotation = targetOrientation * yRotation;
  }
}
