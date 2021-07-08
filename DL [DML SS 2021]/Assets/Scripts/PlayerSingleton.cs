using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class PlayerSingleton : MonoBehaviour
{
    public static PlayerSingleton plr;

    public void Awake()
    {
        if (SceneManager.GetActiveScene().name == "MainScene") 
        {
            if (!plr)
            {
                DontDestroyOnLoad(gameObject);
                plr = this;
            }
            else
            {
                plr.transform.position = transform.position;
                Destroy(gameObject);
            }
        }
    }
}