using UnityEngine;

public class DataManagerSingleton : MonoBehaviour
{
    public static DataManagerSingleton Instance;

    public string finalTimeStr;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SetFinalTime(string finalTime)
    {
        finalTimeStr = finalTime;
    }
}