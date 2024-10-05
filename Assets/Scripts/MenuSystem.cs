using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuSystem : MonoBehaviour
{
    private void LoadGame(int index)
    {
        SceneManager.LoadScene(index);
    }
}
