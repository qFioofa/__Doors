using UnityEngine;
using UnityEngine.SceneManagement;

public class levels_menu_controller : MonoBehaviour
{
    
    public void Play_1lvl()
    {
        // Загрузка сцены игры 
        SceneManager.LoadScene("1lvl_scene");
    }

    public void Play_2lvl()
    {
        // Загрузка сцены игры 
        SceneManager.LoadScene("2lvl_scene");
    }
    public void Play_3lvl()
    {
        // Загрузка сцены игры 
        SceneManager.LoadScene("3lvl_scene");
    }
    
    public void Play_4lvl()
    {
        // Загрузка сцены игры
        SceneManager.LoadScene("4lvl_scene");
    }
    
    public void Play_5lvl()
    {
        // Загрузка сцены игры 
        SceneManager.LoadScene("5lvl_scene");
    }

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("menu"); // Загрузка главного меню
    }

}