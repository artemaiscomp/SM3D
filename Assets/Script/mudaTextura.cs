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
    private Material[] materialTeto = new Material[8];
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
                txtMonolith.text = "Este estilo veio da obra A Noite Estrelada, do artista Vincent van Gogh. Tal obra pós-impressionista, pintada em 1889, retrata a vista que o autor tinha quando olhava pela janela do quarto no hospício em que foi internado. Uma boa parte dos elementos presentes foi baseada na imaginação do pintor, por isso o uso de algumas cores específicas, figuras distorcidas e um vilarejo que sequer existia na cena original.";
                index = 0;
                break;
            case "Porta_Grito":
                txtMonolith.text = "O estilo em Questão veio de uma das obras da série O Grito, do artista Norueguês Edvard Munch, pintada em 1893. Tal pintura, baseado no relato escrito em seu diário, retrata a visão do autor de um ocorrido durante seu passeio com amigos em que o céu pareceu ficar vermelho e um grito infinito ocupava toda a natureza.";
                index = 1;
                break;
            case "Porta_Mondrian":
                txtMonolith.text = "Uma obra do Neoplasticismo que contêm apenas 3 cores e retas, tanto na vertical quanto na horizontal. Composição com Amarelo, Azul e Vermelho, de Piet Mondrian, usava a teoria de abstrair quase ao máximo as formas. Apesar de que até uma criança com uma régua e algumas cores poderia fazê-la com facilidade, há muito mais que isso, criando um efeito monumental, apesar da escassez proposital de elementos gráficos.";
                index = 2;
                break;
            case "Porta_Guernica":
                txtMonolith.text = "Este estilo, basicamente em escala de cinzas, veio do quadro Guernica, do artista Pablo Picasso, pintada em 1937. Na obra pode-se notar elementos marcantes, como guerra, morte, fome e opressão, entre outros. Dessa forma, Guernica representa uma declaração contra a violência da guerra e, assim, acabou se tornando um símbolo da liberdade do ser humano em oposição ao militarismo mundial.";
                index = 3;
                break;
            case "Porta_Romero":
                txtMonolith.text = "Esse estilo veio de uma produção do brasileiro Romero Britto tal peça, em particular, se chama Um Novo Dia e algumas de suas características mais notáveis são a variedade de suas cores saturadas e os destacados contornos pretos entre elas. A energia presente na obra marca bem o estilo do artista, que acabou tornando-o tão popular. ";
                index = 4;
                break;
            case "Porta_Onda":
                txtMonolith.text = "A grande onda de Kanagawa, ou apenas ‘A Onda’, do Artista japonês Hokusai, representa uma grande onda, possivelmente vista ao redor do monte Fuji. Esta xilogravura é a obra mais famosa do autor e a primeira de sua série de obras que buscavam reproduzir diferentes vistas do monte Fuji, datadas no ano de 1832.";
                index = 5;
                break;
            case "Porta_Normal":
                txtMonolith.text = "                         Créditos                       "+
                " Antônio José Melo Leite Júnior"+	"               Natal Anacleto Chicca Junior" +
                "           Rafael Augusto Ferreira do Carmo         Tiago Caúla de Oliveira Maia              Lucas Queiroz Alcântara";
                index = 6;
                break;
            case "Porta_Sacilotto":
                txtMonolith.text = "Este estilo veio do artista brasileiro Luiz Sacilotto. Em sua Obra Concreção 5523 o artista buscou produzir uma intrincada ilusão de óptica. Tal característica, bem comum em seus quadros.As poucas tonalidades geralmente empregadas, a cadência gráfica e as mudanças de direção ajudaram a definir o movimento Op Art no Brasil.";
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
