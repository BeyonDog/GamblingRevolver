using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToGamePlay : MonoBehaviour
{
    // Start is called before the first frame update
    public string targetSceneName;
    

    public void OnButtonClick()
        {
            SceneManager.LoadScene(targetSceneName);
        }
}
