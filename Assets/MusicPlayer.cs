using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicPlayer : MonoBehaviour {

    static GameObject theOne;

    private void Awake()
    {
        //int musicPlayerCount = FindObjectsOfType<MusicPlayer>().Length;
        if (!theOne)
        {

            theOne = gameObject;
            DontDestroyOnLoad(gameObject);

        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Use this for initialization
    void Start () {
        Invoke("LoadFirstScene", 2f);
	}
	
    void LoadFirstScene()
    {
        SceneManager.LoadScene(1);
    }
}
