using UnityEngine;
using System.Collections;

public class Scrolling : MonoBehaviour
{
    public RectTransform myRect;
    int speed = 2;
	
	// Update is called once per frame
	void Update ()
    {
       myRect.position += Vector3.up * speed;
        
	}
    
}
