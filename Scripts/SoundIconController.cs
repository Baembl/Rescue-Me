using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundIconController : MonoBehaviour
{
    public static SoundIconController instance; // Creates a static varible for a MusicControlScript instance

    public void Awake() // Runs before void Start()
    {
        DontDestroyOnLoad(this.gameObject); // Don't destroy this gameObject when loading different scenes
    }
}
