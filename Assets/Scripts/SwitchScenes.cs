using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class SwitchScenes : MonoBehaviour
{
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Keypad1))
        {
            SceneManager.LoadScene("Credits");
        }
        if (Input.GetKeyDown(KeyCode.Keypad2))
        {
            SceneManager.LoadScene("GameScene");
        }
        if (Input.GetKeyDown(KeyCode.Keypad3))
        {
            SceneManager.LoadScene("Lose");
        }
        if (Input.GetKeyDown(KeyCode.Keypad4))
        {
            SceneManager.LoadScene("TitleScreen");
        }
        if (Input.GetKeyDown(KeyCode.Keypad5))
        {
            SceneManager.LoadScene("Win");
        }
    }
}
