
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SettingsInPauseController : MonoBehaviour
{
    public Slider volumeSlider;
    public Slider sensitivitySlider;

    // Метод для изменения громкости
    public void SetVolume(float volume)
    {
        AudioListener.volume = volume;
        PlayerPrefs.SetFloat("Volume", volume); // Сохранение громкости
    }

    // Метод для изменения чувствительности мыши
    public void SetSensitivity(float sensitivity)
    {
        PlayerPrefs.SetFloat("Sensitivity", sensitivity); // Сохранение чувствительности
    }

    // Метод для возврата в главное меню
    public void BackToPause()
    {
       SceneManager.UnloadSceneAsync("SettingsInPause");
    }
}