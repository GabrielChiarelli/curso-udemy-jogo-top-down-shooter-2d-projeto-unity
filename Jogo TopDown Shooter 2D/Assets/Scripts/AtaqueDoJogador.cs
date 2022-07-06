using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueDoJogador : MonoBehaviour
{
    public Transform localDoAtaque;
    public GameObject projetil;
    public AudioSource somDoAtaque;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Instantiate(projetil, localDoAtaque.position, localDoAtaque.rotation);
            somDoAtaque.Play();
        }
    }
}
