using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Texto : MonoBehaviour
{
    public GameObject texto;
    // Start is called before the first frame update
    void Start()
    {
      texto.SetActive(false);
      controladorjuego.evento_texto += Show;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Show() {
      texto.SetActive(true);
    }
}
