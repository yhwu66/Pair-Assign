
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeTime : MonoBehaviour
{
private float DelayBeforeLoading = 10f;

private string sceneNameToLoad;
private float timeElapsed;


  private void Update()
    {
        timeElapsed += Time.deltaTime;

        if (timeElapsed > DelayBeforeLoading)
        {
            SceneManager.LoadScene(sceneNameToLoad);
        }
    }

}