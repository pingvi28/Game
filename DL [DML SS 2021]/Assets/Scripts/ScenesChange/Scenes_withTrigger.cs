using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Scenes_withTrigger : MonoBehaviour
{
    public string triggerTag;
    public string scenesChange;
    private bool turningOn = false;

    private void Start(){
        turningOn = true;
    }

    private void OnTriggerStay(Collider other)
    {
        if (turningOn && other.CompareTag(triggerTag))
        {
            NextLevel();
        }
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(scenesChange);
    }
}
