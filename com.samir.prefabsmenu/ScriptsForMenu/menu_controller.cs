using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Метод для кнопки "Играть"
    public void PlayGame()
    {
        // Загрузка сцены игры 
        SceneManager.LoadScene("levels");
    }

    // Метод для кнопки "Настройки"
    public void OpenSettings()
    {
        // Загрузка сцены настроек
        SceneManager.LoadScene("SettingsScene");
    }

    // Метод для кнопки "Выход"
    public void QuitGame()
    {
        // Выход из приложения
        Application.Quit();
        Debug.Log("Игра закрыта");
    }
}