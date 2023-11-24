using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneNavigator : MonoBehaviour
{
    // enum
    public enum Scenes {
        MainMenu,
        Settings,
        Credits,
        Game,
        Exit
    }
public Scenes scene;

// Navigarea intre scene
public void goToScene() {
    // Verificam scena
    if(scene == Scenes.Exit) {
# if UNITY_EDITOR
UnityEditor.EditorApplication.isPlaying = false;
# else  
        Application.Quit();
# endif
    } else {
    SceneManager.LoadScene(scene.ToString());
    }
  }
}
