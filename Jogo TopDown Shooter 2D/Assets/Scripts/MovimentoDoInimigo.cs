using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoDoInimigo : MonoBehaviour
{
    public float velocidadeMinimaDoInimigo;
    public float velocidadeMaximaDoInimigo;
    public float velocidadeAtualDoInimigo;

    public int danoParaDar;

    private Rigidbody2D oRigidbody2D;
    private Transform oJogador;

    // Start is called before the first frame update
    void Start()
    {
        velocidadeAtualDoInimigo = Random.Range(velocidadeMinimaDoInimigo, velocidadeMaximaDoInimigo);
        oRigidbody2D = GetComponent<Rigidbody2D>();
        oJogador = FindObjectOfType<MovimentoDoJogador>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(FindObjectOfType<GameManager>().jogadorEstaVivo == true)
        {
            transform.position = Vector2.MoveTowards(transform.position, oJogador.position, velocidadeAtualDoInimigo * Time.deltaTime);

            Vector3 direcaoDoInimigo = oJogador.position - transform.position;
            float anguloParaOlhar = Mathf.Atan2(direcaoDoInimigo.y, direcaoDoInimigo.x) * Mathf.Rad2Deg;

            oRigidbody2D.rotation = anguloParaOlhar;
        }
    }

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if(collisionInfo.gameObject.CompareTag("Player"))
        {
            collisionInfo.gameObject.GetComponent<VidaDoJogador>().MachucarJogador(danoParaDar);
        }
    }
}
