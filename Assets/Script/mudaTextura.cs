using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mudaTextura : MonoBehaviour
{
    [SerializeField]
    private GameObject[] objGerais;

    [SerializeField]
    private GameObject[] paredes;

    private GameObject elev1;
    private GameObject elev2;

    private GameObject chao;
    private GameObject balcao;
    private GameObject pedregulho;
    private GameObject janela;
    public GameObject cadeira0;
    public GameObject cadeira1;
    public GameObject cadeira2;
    public GameObject cadeira3;
    public GameObject cadeira4;
    public GameObject cadeira5;

    //Materiais
    [SerializeField]
    private Material[] materialObjGerais = new Material[8];
    [SerializeField]
    private Material[] materialParedes = new Material[8];
    [SerializeField]
    private Material[] materialElevador = new Material[8];
    [SerializeField]
    private Material[] materialChao = new Material[8];
    [SerializeField]
    private Material[] materialBalcao = new Material[8];
    [SerializeField]
    private Material[] materialPedra = new Material[8];
    [SerializeField]
    private Material[] materialJanela = new Material[8];

    [SerializeField]
    public Material materialCadeirasNormais;

    private int index = 6;

    public Text txtMonolith;


    void Start()
    {
        objGerais = GameObject.FindGameObjectsWithTag("ObjetosGerais");
        paredes = GameObject.FindGameObjectsWithTag("Parede");
        elev1 = GameObject.Find("Elevador1");
        elev2 = GameObject.Find("Elevador2");
        chao = GameObject.Find("Chao");
        balcao = GameObject.Find("Balcao");
        pedregulho = GameObject.Find("Pedregulho");
        janela = GameObject.Find("Janela");
        //Encontra cadeiras
        cadeira0 = GameObject.Find("Chair_Conference");
        cadeira1 = GameObject.Find("Chair_Conference (1)");
        cadeira2 = GameObject.Find("Chair_Conference (2)");
        cadeira3 = GameObject.Find("Chair_Conference (3)");
        cadeira4 = GameObject.Find("Chair_Conference (4)");
        cadeira5 = GameObject.Find("Chair_Conference (5)");


    }

    void OnTriggerEnter(Collider other)
    {
        switch (other.name)
        {
            case "Porta_NE":
                txtMonolith.text = "Entrou na Noite Estrelada Boa po";
                index = 0;
                break;
            case "Porta_Grito":
                txtMonolith.text = "Entrou no Grito fala baixo po";
                index = 1;
                break;
            case "Porta_Mondrian":
                txtMonolith.text = "Entrou no Mondrian nice po";
                index = 2;
                break;
            case "Porta_Guernica":
                txtMonolith.text = "Entrou em Guernica, quer guerra po?";
                index = 3;
                break;
            case "Porta_Romero":
                txtMonolith.text = "Entrou no Romero, quebra os vaso nao po";
                index = 4;
                break;
            case "Porta_Onda":
                txtMonolith.text = "Entrou na Onda taca a mae pra ver se quica po";
                index = 5;
                break;
            case "Porta_Normal":
                txtMonolith.text = "Entrou no Normal, normal po";
                index = 6;
                break;
            case "Porta_Sacilotto":
                txtMonolith.text = "Entrou no Sarcilotto, nome de ketchup po";
                index = 7;
                break;
        }
        for (int i = 0; i < objGerais.Length; i++)
        {
            objGerais[i].GetComponent<Renderer>().material = materialObjGerais[index];
        }
        for (int i = 0; i < paredes.Length; i++)
        {
            paredes[i].GetComponent<Renderer>().material = materialParedes[index];
        }
        elev1.GetComponent<Renderer>().material = materialElevador[index];
        elev2.GetComponent<Renderer>().material = materialElevador[index];
        chao.GetComponent<Renderer>().material = materialChao[index];
        balcao.GetComponent<Renderer>().material = materialBalcao[index];
        janela.GetComponent<Renderer>().material = materialJanela[index];
        pedregulho.GetComponent<Renderer>().material = materialPedra[index];

        if (index == 6)
        {
            cadeira0.GetComponent<Renderer>().material = materialCadeirasNormais;
            cadeira1.GetComponent<Renderer>().material = materialCadeirasNormais;
            cadeira2.GetComponent<Renderer>().material = materialCadeirasNormais;
            cadeira3.GetComponent<Renderer>().material = materialCadeirasNormais;
            cadeira4.GetComponent<Renderer>().material = materialCadeirasNormais;
            cadeira5.GetComponent<Renderer>().material = materialCadeirasNormais;
        }
    }
}
