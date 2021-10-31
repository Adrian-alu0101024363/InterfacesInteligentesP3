using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cylindertypeA : MonoBehaviour
{
  public GameObject cylynder;
  [SerializeField] private GameObject Player;
  bool already = false;
  private void OnTriggerEnter(Collider other) {
    if (other.gameObject.tag == "Player") {
      transform.localScale += new Vector3(0.2f, 0.2f , 0.2f);
      controladorjuego.fuerza_change();
    }
  }
    // Start is called before the first frame update
    void Start()
    {
      controladorjuego.evento_A += texto;
    }

    // Update is called once per frame
    void Update()
    {
      Vector3 direction = Player.transform.position - transform.position;
      if (Input.GetKeyUp(KeyCode.Space)) {
        Debug.Log(direction.ToString());
        if (direction.z > -5.5 && direction.z < 5.5) {
          transform.position = new Vector3(transform.position.x + 5f, transform.position.y, transform.position.z + 5f);
        }
    } else {
        if (direction.z > -0.5 && direction.z < 0.5) {
          Change(already);
          already = true;
          controladorjuego.orientar();
        } else {
          already = false;
        }
    }
  }
  void Change(bool already) {
    if (!already) {
      controladorjuego.color_change();
    }
  }
  void texto() {
    controladorjuego.evento_texto();
  }
}
