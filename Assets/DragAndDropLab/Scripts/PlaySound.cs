using UnityEngine;

public class PlaySound : MonoBehaviour
{    
    [SerializeField] private AudioClip m_AudioClip;
    [SerializeField] private AudioSource m_AudioSource;

    public void PlayClickSound()
    {
        if (!m_AudioSource.isPlaying)
        {
            m_AudioSource.clip = m_AudioClip;
            m_AudioSource.Play();
        }
    }
}
