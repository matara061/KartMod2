using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable] // Enfia tudo oq est� abaixo no serialized
public class Sound // - � daqui que vem a letra S do foreach 
{
    public string name;

    public AudioClip clip;

    [Range(0f, 2f)] // Alcance minimo e maximo do volume e do tom
    public float volume;
    [Range(.1f, 3f)]
    public float pitch; // Tom

    public bool loop;

    [HideInInspector] // � publico mas n�o deve aparecer 
    public AudioSource source; // vamos chamar o Som em outros codigos atrav�s da vairiavel Source
}
