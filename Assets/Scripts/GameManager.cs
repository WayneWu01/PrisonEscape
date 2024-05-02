using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Normal.Realtime;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [Header("Normcore")]
    public Realtime _realtime;
    [SerializeField] private string roomName;
    bool loadingScene = false;


    [Header("Options")]
    public bool backgroundMusic = true;

    // color choices
    public enum Colors
    {
        Blue, Green, Pink, Red
    }
    public Colors colorChoice = Colors.Blue;

    private void Start()
    {
        _realtime = FindObjectOfType<Realtime>();

        int menuCode = Random.Range(111111, 1000000);
        _realtime.Connect(menuCode.ToString());
    }

    public void LoadSceneAndConnect(string newRoomName, string sceneName)
    {
        if (loadingScene) return;

        roomName = newRoomName;

        StartCoroutine(LoadAsyncScene(sceneName));
    }

    public IEnumerator LoadAsyncScene(string nextScene)
    {
        loadingScene = true;

        _realtime.Disconnect();
        _realtime = null;

        //int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        //Scene nextScene = SceneManager.GetSceneByBuildIndex(currentSceneIndex + 1);
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(nextScene);

        while (!asyncLoad.isDone)
        {
            yield return null;
        }

        _realtime = FindObjectOfType<Realtime>();
        _realtime.Connect(roomName);

        loadingScene = false;
    }

    public string getRoomName()
    {
        return roomName;
    }

    // singleton setup for data persistence across scenes
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
