using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
  private Vector3 PlayerMovementInput;
  [SerializeField] private Rigidbody PlayerBody;
  [SerializeField] public float Speed;
  [SerializeField] bool arrows;
  [SerializeField] bool wasd;
  public int points = 0;
    // Update is called once per frame
    void Update()
    {
      PlayerMovementInput = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
      if (arrows) {
        bool right = Input.GetKey(KeyCode.RightArrow);
        bool left = Input.GetKey(KeyCode.LeftArrow);
        bool down = Input.GetKey(KeyCode.DownArrow);
        bool up = Input.GetKey(KeyCode.UpArrow);
        if (right || left || down || up) {
          MovePlayer();
        }
      }
      if (wasd) {
        bool right = Input.GetKey(KeyCode.D);
        bool left = Input.GetKey(KeyCode.A);
        bool down = Input.GetKey(KeyCode.S);
        bool up = Input.GetKey(KeyCode.W);
        if (right || left || down || up) {
          MovePlayer();
        }  
      } 
    }
     private void OnTriggerEnter(Collider other) {
      Points();
    }
    private void MovePlayer() {
      Vector3 MoveVector = transform.TransformDirection(PlayerMovementInput) * Speed;
      PlayerBody.velocity = new Vector3(MoveVector.x, PlayerBody.velocity.y, MoveVector.z);
    }
    public void Points() {
      points++;
      Debug.Log("Player points" + points);
    }
}
