using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    [SerializeField] private int _indexSceneLoad;
    public void LoadScene()
    {
        SceneManager.LoadScene(_indexSceneLoad);
    }
}
