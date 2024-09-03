using UnityEngine;

public class audio_manager : MonoBehaviour
{
    [Header("------ Audio Source ------")]
    [SerializeField] AudioSource MusicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("------ Audio Clip ------")]
    public AudioClip Background;
    public AudioClip CoinCollect;

    private void Start()
    {
        MusicSource.clip = Background;
        MusicSource.Play();
    }

    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }
}
    
