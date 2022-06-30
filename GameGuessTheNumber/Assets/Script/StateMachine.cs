using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StateMachine : MonoBehaviour
{
    [SerializeField] private GameObject firstScreen;
    [SerializeField] private GameObject secondScreen;
    [SerializeField] private GameObject otherScreen;

    private GameObject currentScreen;
  
    private void Start()
    {
        firstScreen.SetActive(true);
        currentScreen = firstScreen;
    }
    public void StartGame(GameObject state)
    {
        if(currentScreen != null)
        {
            currentScreen.SetActive(false);
            state.SetActive(true);
            currentScreen = state;
        }
    }
    public void OtherClick(GameObject otherState)
    {
        if(currentScreen != null)
        {
            currentScreen.SetActive(false);
            otherState.SetActive(true);
            currentScreen = otherState;
        }
    }
    public void ExitGame(GameObject exitState)
    {
        if(currentScreen != null)
        {
            currentScreen.SetActive(false);
            exitState.SetActive(true);
            currentScreen = exitState;
        }
    }
}
