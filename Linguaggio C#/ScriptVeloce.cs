using UnityEngine;
using TMPro; 

public class ScriptVeloce : MonoBehaviour
{
    public GameObject scritta;

    void Start()
    {
    
        Invoke("NascondiScritta", 5f);
    }

    void NascondiScritta()
    {
        scritta.SetActive(false);
    }
}

