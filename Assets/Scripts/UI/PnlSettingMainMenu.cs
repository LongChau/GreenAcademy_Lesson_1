using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class PnlSettingMainMenu : MonoBehaviour
{
    [SerializeField]
    private AudioMixer _audioMixer;
    [SerializeField]
    private Slider _slider;
    private float _volumn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //_audioMixer.GetFloat("VolumnMainMenu", out _volumn);
        _volumn = _slider.value;
        _audioMixer.SetFloat("VolumnMainMenu", _volumn);
    }
}
