using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

    public Transform Setting;
    private static Destroy instance;

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

        if (this.gameObject.activeInHierarchy == true)
        {
            this.gameObject.SetActive(false);
        }
    }
}
