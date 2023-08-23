using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadScene : MonoBehaviour
{
    public void Restart()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    //void OnEnable()
    //{
    //    // �� �Ŵ����� sceneLoaded�� ü���� �Ǵ�.
    //    SceneManager.sceneLoaded += OnSceneLoaded;
    //}

    //// ü���� �ɾ �� �Լ��� �� ������ ȣ��ȴ�.
    //void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    //{
    //    Debug.Log("OnSceneLoaded: " + scene.name);
    //    Debug.Log(mode);
    //}

    //void OnDisable()
    //{
    //    SceneManager.sceneLoaded -= OnSceneLoaded;
    //}
}
