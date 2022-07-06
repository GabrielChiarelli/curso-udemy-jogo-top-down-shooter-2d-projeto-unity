using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VidaDoJogador : MonoBehaviour
{
    public int vidaMaximaDoJogador;
    public int vidaAtualDoJogador;

    public Slider barraDeVidaDoJogador;

    public AudioSource somDeDano;
    public AudioSource somDeVida;

    // Start is called before the first frame update
    void Start()
    {
        vidaAtualDoJogador = vidaMaximaDoJogador;
        barraDeVidaDoJogador.maxValue = vidaMaximaDoJogador;
        barraDeVidaDoJogador.value = vidaAtualDoJogador;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GanharVida()
    {
        if(vidaAtualDoJogador < vidaMaximaDoJogador)
        {
            vidaAtualDoJogador += 1;
            barraDeVidaDoJogador.value = vidaAtualDoJogador;
        }
        else
        {
            vidaAtualDoJogador = vidaMaximaDoJogador;
            barraDeVidaDoJogador.value = vidaAtualDoJogador;
        }

        somDeVida.Play();
    }

    public void MachucarJogador(int danoParaReceber)
    {
        vidaAtualDoJogador -= danoParaReceber;
        somDeDano.Play();
        barraDeVidaDoJogador.value = vidaAtualDoJogador;

        if(vidaAtualDoJogador <= 0)
        {
            FindObjectOfType<GameManager>().GameOver();
            Destroy(this.gameObject);
        }
    }
}
