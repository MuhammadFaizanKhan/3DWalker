using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

/// <summary>
/// Function: Handle UI scene additive Load in Main Scene.
/// Author: Muhammad Faizan Khan
/// </summary>
namespace ThreeDWalker
{
    public class SceneLoader : MonoBehaviour
    {
        public string sceneToLoad = "UIScene";
        public bool loadSceneAsync = true;
        void Awake()
        {
            if (sceneToLoad != "")
            {
                if (loadSceneAsync)
                {
                    SceneManager.LoadSceneAsync(sceneToLoad, LoadSceneMode.Additive);
                }
                else
                {
                    SceneManager.LoadScene(sceneToLoad, LoadSceneMode.Additive);
                }
            }
            else {
                Debug.LogError("Scene Name is empty. No additive scene loaded.");
            }

        }
    }
}
