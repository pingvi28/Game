using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Home : MonoBehaviour
{
    public void goToHome() 
    {
        SceneManager.LoadScene("MainScene");
    }
}
