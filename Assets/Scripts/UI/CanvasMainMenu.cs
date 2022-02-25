using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasMainMenu : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI _txtScore;
    [SerializeField]
    private TextMeshProUGUI _txtTime;
    [SerializeField]
    private PnlSettingMainMenu _pnlSetting;

    // Start is called before the first frame update
    void Start()
    {
        var score = PlayerPrefs.GetInt("score", 0);
        var time = (int)PlayerPrefs.GetFloat("DeadTime", 0);
        _txtScore.SetText($"Score: {score}");
        _txtTime.SetText($"Time: {time}");
    }

    public void OnBtnStartClicked()
    {
        
        SceneManager.LoadScene("PlayScene");
    }

    public void OnBtnExitClicked()
    {
        Application.Quit();
    }
    public void OnlButtonSetingClick()
    {
        Debug.Log("Setting");
        _pnlSetting.gameObject.SetActive(true);
    }
}
