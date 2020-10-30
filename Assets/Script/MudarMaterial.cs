using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MudarMaterial : MonoBehaviour
{

    public Material matChao;
    public Material matBola;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E)){
            GetComponent<Renderer>().material = matChao;
        }
        else if(Input.GetKeyDown(KeyCode.J)){
            GetComponent<Renderer>().material = matBola;
        }

    }
}
