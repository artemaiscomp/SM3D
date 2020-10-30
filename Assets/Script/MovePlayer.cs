using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    private int auxDirecaVert;
    private int auxDirecaHori;
    public float Velocidade;

    public GameObject chao;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(auxDirecaVert !=0){
            transform.Translate(0,0,Velocidade*Time.deltaTime*auxDirecaVert);
        }
        if(auxDirecaHori !=0){
            transform.Translate(Velocidade*Time.deltaTime*auxDirecaHori,0,0);
        }
        
    }

    public void movimentacaoVert(int direcao){
            auxDirecaVert = direcao;

    }
    public void movimentacaoHori(int direcao){
            auxDirecaHori = direcao;

    }
    
   
}

