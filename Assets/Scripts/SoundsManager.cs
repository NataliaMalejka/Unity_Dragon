using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SoundsManager : MonoBehaviour
{
    [SerializeField] private AudioClip backgroundMusic;
    [SerializeField] private AudioClip startGame;
    [SerializeField] private AudioClip collectCoin;
    [SerializeField] private AudioClip addBullet;

    private AudioSource audioSource;
    public enum Sounds
    {
        BackgroundMusic, 
        StartGame,
        CollectCoin,
        AddBullet
    }
    private void Awake()
    {
        if (GameObject.FindGameObjectsWithTag("SoundsManager").Length > 1)
        {
            Destroy(this.gameObject);
        }
    }

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        DontDestroyOnLoad(this.gameObject);

        audioSource.Play();
    }

    public void PlaySounds (Sounds sounds)
    {
        switch(sounds)
        {
            case Sounds.BackgroundMusic:
                audioSource.PlayOneShot(backgroundMusic);
                break;
            case Sounds.StartGame:
                audioSource.PlayOneShot(startGame);
                break;
            case Sounds.CollectCoin:
                audioSource.PlayOneShot(collectCoin);
                break;
            case Sounds.AddBullet:
                audioSource.PlayOneShot(addBullet);
                break;
            default:
                break;
        }
    }
}
