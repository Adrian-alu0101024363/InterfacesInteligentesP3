using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target : MonoBehaviour
{
  public Transform targetObject;
  public float speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
      controladorjuego.orientar += Orientar;
    }

    // Update is called once per frame
    void Update() {

    }
    void Orientar() {
      Vector3 targetDirection = targetObject.position - transform.position;
      float singleStep = speed * Time.deltaTime;
      Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection, singleStep, 0.0f);
      Debug.DrawRay(transform.position, newDirection, Color.red);
      transform.rotation = Quaternion.LookRotation(newDirection);
    }
}
