using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour, IPointerClickHandler
{
    public Quest qu;

    public void OnPointerClick(PointerEventData eventData) 
    {
        if (qu.flag)
        {
            NextLevel();
        }
    }

    public void NextLevel() {
        SceneManager.LoadScene("Intermediate");
    }
}

