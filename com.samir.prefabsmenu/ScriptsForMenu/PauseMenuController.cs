using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;

    

    public void Resume()
    {
        SceneManager.UnloadSceneAsync("PauseMenuScene");
        Time.timeScale = 1f; // Возвращаем время в игре к нормальному значению
        
    }

    public void OpenSettings()
    {
        // Загрузка сцены настроек
        SceneManager.LoadScene("SettingsInPause", LoadSceneMode.Additive);
        
    }
    public void BackToMainMenu()
    {
        SceneManager.LoadScene("menu"); // Загрузка главного меню
        Time.timeScale = 1f;
    }
   
}