using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;


public class MusicController : MonoBehaviour {

    public Slider volume;
    public Slider volume1;
    public AudioSource BGM;
    public AudioSource SFX;
    private static MusicController instance;

    [SerializeField]
    public Transform BgmVolume;
    public Transform SfxVolume;

    // Use this for initialization
    void Start () {

        //Debug.Log(Mathf.RoundToInt(volume.value * 100));
        //Debug.Log(Mathf.RoundToInt(volume1.value * 100));

    }
	
	// Update is called once per frame
	void Update () {

        //mark the voice volume = audio source.volume.value
        BGM.volume = volume.value;
        SFX.volume = volume1.value;

        //set the text of the volume change according the change of slider
        BgmVolume.GetComponent<Text>().text = (volume.value* 100).ToString("F0");
        SfxVolume.GetComponent<Text>().text = (volume1.value * 100).ToString("F0");


    }

    //make it undestroyable
    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }
}
