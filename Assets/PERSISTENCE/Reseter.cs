using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Reseter : MonoBehaviour {
    public bool reset = false;

    void Start () {
        PlayerPrefs.DeleteAll();
    }
}
