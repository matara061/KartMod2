using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using System;
using UnityEngine;

public class AudioManager2 : MonoBehaviour
{
    public Sound[] sounds; // Um array de a�dio, isso permite utilizar uma boa quantidade de a�dio atrav�s de uma �nica fun��o

    public static AudioManager2 instance;
    internal readonly object currentlyPlaying;

    void Awake() // Basicamente � a msm coisa que o void Start, contudo, a prioridade de execu��o sempre vai ser do Awake 
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;

        DontDestroyOnLoad(gameObject); 

        foreach (Sound s in sounds) // Foreach � para percorrer as posi��es de mem�ria do array. podemos dizer que a Letra S s�o os indices
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;

        }
    }

    public void Play(string name) // Caso o nome do a�dio � seja encontrado, vai dar um super hiper mega bug. Se atentar ao nome pr�-definido do Som
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Play();

    }

    public void Stop(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + " not found!");
            return;
        }
        s.source.Stop();
    }


}
