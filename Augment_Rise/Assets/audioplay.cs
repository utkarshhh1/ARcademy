using UnityEngine;
using UnityEngine.UI;

public class audioplay : MonoBehaviour
{
    public AudioClip audioClip; 

    private AudioSource audioSource;
    private bool isPlaying = false;

    private void Awake()
    {
        
        audioSource = GetComponent<AudioSource>();

        
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }
    void start()
    {
        audioSource.Stop();
        isPlaying = false;
    }
    public void ToggleAudio()
    {
        if (!isPlaying)
        {
            if (audioClip != null)
            {
                audioSource.clip = audioClip;
                audioSource.Play();
                isPlaying = true;
            }
            else
            {
                Debug.LogWarning("No audio clip assigned to ToggleAudio script.");
            }
        }
        else
        {
            audioSource.Stop();
            isPlaying = false;
        }
    }

  
    public void PlayMusic()
    {
        if (audioClip != null && !audioSource.isPlaying)
        {
            audioSource.clip = audioClip;
            audioSource.Play();
            isPlaying = true;
        }
    }
}
