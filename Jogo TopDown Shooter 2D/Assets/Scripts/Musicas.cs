using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musicas : MonoBehaviour
{
    public AudioSource musicaDeFundo;
    public AudioSource musicaDeGameOver;

    // Start is called before the first frame update
    void Start()
    {
        TocarMusicaDeFundo();
    }

    public void TocarMusicaDeFundo()
    {
        musicaDeFundo.Play();
    }

    public void TocarMusicaDeGameOver()
    {
        musicaDeFundo.Stop();
        musicaDeGameOver.Play();
    }
}
