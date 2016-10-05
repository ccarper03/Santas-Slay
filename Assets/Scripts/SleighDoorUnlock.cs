using UnityEngine;
using System.Collections;

public class SleighDoorUnlock : MonoBehaviour
{
    public bool gotKey = false; 
    public Animation anim;

    //called once at the start of the game
    void Start()
    {
        anim = GetComponent<Animation>();
        if (gotKey)
        {
            anim.Play();
        }
    }
}
