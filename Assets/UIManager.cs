using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Terrain Manny's Fishing Spot");
    }
    public void StartGame2()
    {
        SceneManager.LoadScene("Shack indoor");
    }
}
