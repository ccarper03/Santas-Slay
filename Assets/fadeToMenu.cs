using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class fadeToMenu : MonoBehaviour {

    public int delayedTimeAmount = 20;
	// Use this for initialization
	void Start () {
        StartCoroutine(DelayedTime());
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    IEnumerator DelayedTime()
    {
        yield return new WaitForSeconds(delayedTimeAmount);
        SceneManager.LoadScene("TitleScreen");
    }
}
