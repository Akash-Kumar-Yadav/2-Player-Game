using Scripts.Utilities;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Scripts.UI
{
    public class UIManager : MonoBehaviour
    {
        [SerializeField] GameObject gamePanel;
        [SerializeField] GameObject quitPanel;
        [SerializeField] GameObject gameOverPanel;
        [SerializeField] GameObject mainMenuPanel;

        private void OnEnable()
        {
            Events.OnGameover += GameOver;
        }
        private void Start()
        {
            mainMenuPanel.SetActive(true);
            gamePanel.SetActive(false);
            quitPanel.SetActive(false);
            gameOverPanel.SetActive(false);
        }

        public void PlayMethod()
        {
            mainMenuPanel.SetActive(false);
            gamePanel.SetActive(true);
        } 
        public void ExitMethod()
        {
            quitPanel.SetActive(true);
            gamePanel.SetActive(false);
        } 
        public void No()
        {
            quitPanel.SetActive(false);
            gamePanel.SetActive(true);
        } 
        public void GameOver()
        {
            gameOverPanel.SetActive(true);
            gamePanel.SetActive(false);
        }
        
        public void Restart()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        public void Yes()
        {
            Application.Quit();
        }

        private void OnDisable()
        {
            Events.OnGameover -= GameOver;
        }
    }
}
