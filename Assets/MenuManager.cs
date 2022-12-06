using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField]
    private GameObject Menu;
    [SerializeField]
    private GameObject Option;

    public void Start()
    {
        Menu = GameObject.Find("/Canvas/Main");
        Option = GameObject.Find("/Canvas/Option");

        Menu.SetActive(true);
        Option.SetActive(false);
    }

    public void play()
    {
        SceneManager.LoadScene(sceneName:"Main");
    }
    
    public void option()
    {
        Menu.SetActive(false);
        Option.SetActive(true);
    }
    public void Back()
    {
        Menu.SetActive(true);
        Option.SetActive(false);
    }
}
