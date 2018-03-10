using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBehavior : MonoBehaviour {
  Animator animator;

  // Use this for initialization
  void Start() {
    animator = GetComponent<Animator>();
  }

  // Update is called once per frame
  void Update() {
    if (Input.GetMouseButtonDown(0)) {
      animator.SetTrigger("shoot");

      // TODO: Shooting
      /*
      GetComponent<AudioSource>().Play();

      RaycastHit hit;
      if(Physics.Raycast(bulletSpawn.position, bulletSpawn.forward, out hit, 300f, layerMask.value)) {
        Debug.DrawLine(transform.position, hit.point, Color.magenta);
        if(hit.transform.CompareTag("Enemy")) {
          squibManager.GetComponent<SparkManager>().SpawnSpark(hit.point);
        } else {
          sparkManager.GetComponent<SparkManager>().SpawnSpark(hit.point);
        }
        hit.collider.BroadcastMessage("ApplyDamage", damage, SendMessageOptions.DontRequireReceiver);
      }
      */
    }
  }
}
