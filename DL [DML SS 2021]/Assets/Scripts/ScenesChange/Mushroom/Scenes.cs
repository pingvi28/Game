using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData) {
        Debug.Log("sasa");
        NextLevel();
    }

    public void NextLevel() {
        SceneManager.LoadScene("CapsGame");
    }
}

