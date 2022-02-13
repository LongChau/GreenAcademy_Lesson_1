using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasMainMenu : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _txtScore;

    // Start is called before the first frame update
    void Start()
    {
        var score = PlayerPrefs.GetInt("score", 0);
        _txtScore.SetText($"Score: {score}");
    }

    public void OnBtnStartClicked()
    {
        SceneManager.LoadScene("PlayScene");
    }

    public void OnBtnExitClicked()
    {
        Application.Quit();
    }
}
