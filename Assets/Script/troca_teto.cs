using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class troca_teto : MonoBehaviour
{
    public int indice_p;
    public GameObject teto;
    public Material[] text_teto = new Material[8];
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    void OnTriggerEnter(Collider other)
    {
        teto.GetComponent<Renderer>().material = text_teto[indice_p];
      
        
    }
}
