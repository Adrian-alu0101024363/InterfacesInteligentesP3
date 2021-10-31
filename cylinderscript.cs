using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cylinderscript : MonoBehaviour
{
  public GameObject cylynder;
  private Renderer cylinderRenderer;
  private Color color;
  private float random1, random2, random3;
  public float fuerza = 1.2f;
  private void OnTriggerEnter(Collider other) {
    if (other.gameObject.tag == "Player") {
      transform.localScale += new Vector3(0.2f, 0.2f , 0.2f);
      controladorjuego.evento_A();
    }
  }
    // Start is called before the first frame update
    void Start()
    {
        cylinderRenderer = cylynder.GetComponent<Renderer>();
        controladorjuego.color_change += change;
        controladorjuego.fuerza_change += changeFuerza;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void change() {
      //Change color
      random1 = Random.Range(0f, 1f);
      random2 = Random.Range(0f, 1f);
      random3 = Random.Range(0f, 1f);
      color = new Color(random1, random2, random3);
      cylinderRenderer.material.SetColor("_Color", color);
    }
    void changeFuerza() {
      fuerza++;
    }
}
