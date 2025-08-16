using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;   // needed for InputField

public class MenuUIHandler : MonoBehaviour
{
    public InputField inputName;  // drag your Canvas InputField here in Inspector

    public void StartNew()
    {
        // Save the name into GameManager
        if (!string.IsNullOrEmpty(inputName.text))
        {
            GameManager.Instance.playerName = inputName.text;
        }
        else
        {
            GameManager.Instance.playerName = "Player"; // fallback if empty
        }

        SceneManager.LoadScene(1); // load Main scene
    }
}
