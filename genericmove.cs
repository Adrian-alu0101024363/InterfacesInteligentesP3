using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class genericmove : MonoBehaviour
{    
  private Vector3 PlayerMovementInput;
  [SerializeField] private Rigidbody PlayerBody;
  [SerializeField] public float Speed;
  [SerializeField] bool active;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
      if (active) {
        PlayerMovementInput = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        bool right = Input.GetKey(KeyCode.D);
        bool left = Input.GetKey(KeyCode.A);
        bool down = Input.GetKey(KeyCode.S);
        bool up = Input.GetKey(KeyCode.W);
        if (right || left || down || up) {
          MovePlayer();
        } 
      } 
    }
    void MovePlayer() {
      Vector3 MoveVector = transform.TransformDirection(PlayerMovementInput) * Speed;
      PlayerBody.velocity = new Vector3(MoveVector.x, PlayerBody.velocity.y, MoveVector.z);
    }
}
