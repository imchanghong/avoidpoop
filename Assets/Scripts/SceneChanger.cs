using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class SceneChanger : MonoBehaviour
{
    public string sceneName;
    private Touch touch;
    private void Update()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                SceneChange(sceneName);
            }
        }
        else if (Input.GetMouseButtonDown(0))
        {
            SceneChange(sceneName);
        }
    }
    public void SceneChange(string name)
    {
        try
        {
            SceneManager.LoadScene(name);
        } catch
        {
            Debug.LogError("Scene 이름을 적어주세요!");
        }
    }


}
