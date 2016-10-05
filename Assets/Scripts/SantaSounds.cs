using UnityEngine;
using System.Collections;

public class SantaSounds : MonoBehaviour
{

    public AudioSource santaSoundsSource;
    public AudioClip[] santaSounds;

    private float timer;
    public float delayTimer;
    private int index;

    public enum State { None, PlaySounds};
    public State santaSoundState;
    void Update()
    {
        if (santaSoundState == State.PlaySounds)
        { 
            timer += Time.deltaTime;
            if (timer >= delayTimer)
            {
                timer = 0;
                index = Random.Range(0, santaSounds.Length);
                santaSoundsSource.clip = santaSounds[index];
                if (!santaSoundsSource.isPlaying)
                {
                    santaSoundsSource.PlayOneShot(santaSounds[index]);
                }
            }
        }
    }
}

