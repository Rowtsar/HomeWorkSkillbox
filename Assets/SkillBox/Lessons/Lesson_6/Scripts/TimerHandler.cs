using UnityEngine;
using UnityEngine.UI;

public class TimerHandler : MonoBehaviour
{
    [SerializeField] private MainTimer mainTimer;
    [SerializeField] private AdditionalTimer additionalTimer;

    private Text timerTextMain;
    private Text timerTextAdditional;

    private float currentTime;

    private void Awake()
    {
        timerTextMain = mainTimer.GetComponent<Text>();
        timerTextAdditional = additionalTimer.GetComponent<Text>();

    }
    void Update()
    {
        currentTime = Mathf.Round(Time.time);
        timerTextAdditional.text = Mathf.Round(Time.time / 5).ToString();
        timerTextMain.text = currentTime.ToString();
               
    }
}
