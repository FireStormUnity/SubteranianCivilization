using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    public void Changescene(int nextSceneIndex)
    {
        SceneManager.LoadScene(nextSceneIndex);
    }
}