using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{
    //arrumando a animacao da transicao entre cenas
    public Animator transition;
    public float transitionTime = 1f;

    public void PlayGame()
    {
        //avisando que o botao da load na outra cena pelo coroutine da transicao
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    //arrumando a transicao em ordem com tempo de espera e carregamento da cena
    IEnumerator LoadLevel(int levelIndex)
    {
        //animacao
        transition.SetTrigger("Start");
        //esperar
        yield return new WaitForSeconds(transitionTime);
        //carregar cena
        SceneManager.LoadScene(levelIndex);
    }

    //botao de sair do jogo
    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
