using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoDoJogador : MonoBehaviour
{
    public float velocidadeDoJogador;
    public Rigidbody2D oRigidbody2D;
    public Camera cameraDoJogo;

    private Vector2 movimentoDoJogador;
    private Vector2 posicaoDoMouse;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movimentoDoJogador.x = Input.GetAxisRaw("Horizontal");
        movimentoDoJogador.y = Input.GetAxisRaw("Vertical");

        posicaoDoMouse = cameraDoJogo.ScreenToWorldPoint(Input.mousePosition);
    }

    void FixedUpdate()
    {
        oRigidbody2D.MovePosition(oRigidbody2D.position + movimentoDoJogador.normalized * velocidadeDoJogador * Time.deltaTime);

        Vector2 direcaoDoOlhar = posicaoDoMouse - oRigidbody2D.position;
        float anguloDoJogador = Mathf.Atan2(direcaoDoOlhar.y, direcaoDoOlhar.x) * Mathf.Rad2Deg;

        oRigidbody2D.rotation = anguloDoJogador;
    }
}
