using UnityEngine;
using UnityEngine.UI; 
using TMPro; 
public class TimerUI : MonoBehaviour
{
    public float tempoRimanente = 300f;
    public TextMeshProUGUI testoTimer;
    public GameObject scritta;
    public GameObject NPC;
   void Start()
    {
        scritta.SetActive(false);
    }

    void Update()
    {
        if (tempoRimanente > 0)
        {
            tempoRimanente -= Time.deltaTime;
            AggiornaTesto(tempoRimanente);
            if(tempoRimanente <= 0)
            {
                scritta.SetActive (true);
                NPC.SetActive (false);

            }
        }
    }

    void AggiornaTesto(float tempo)
    {
        int minuti = Mathf.FloorToInt(tempo / 60);
        int secondi = Mathf.FloorToInt(tempo % 60);
        testoTimer.text = string.Format("{0:00}:{1:00}", minuti, secondi);
    }
}


