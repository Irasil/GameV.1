using UnityEngine;
using UnityEngine.SceneManagement;

public class dead : MonoBehaviour
{
    public static bool GameIsPaused = false;
    //public GameObject deadMenuUI;

    
    public void PlayGame() {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
   
    //public void Pause()
    //{
    //    Cursor.lockState = CursorLockMode.None;
    //    Pause();
    //    deadMenuUI.SetActive(true);
    //    Time.timeScale = 0f;
    //    GameIsPaused = true;
    //}
   
}