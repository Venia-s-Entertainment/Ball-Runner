using UnityEngine;

public class FinishBehaviour : MonoBehaviour
{
    public bool IsWin;
    public bool wasWin;
    public bool nextLevel;
    public ScoreLogic score;
    public MapController map;
    [SerializeField] LevelChanger levelchange;
    public ButtonBehaviour buttonNextLevel, buttonRetry;
    public TimeLogic time;
    public int currentLocation = 0;
    public Vector3[] locations = new Vector3[]
    {
       new Vector3(-82.1299973f,-2.20310307f,0),
       new Vector3(-221.600006f,7.63785505f,0),
       new Vector3(-433.899994f,46.8830719f, 0),
       new Vector3(-709.5f,9.18943024f, 0),
       new Vector3(-920.5f,38.5999985f,0),
       new Vector3(-1081.49756f,65.7317429f,0),
       new Vector3(-1403.36011f,24.4000244f, 0),
       new Vector3(-1516.5f,66.6f,0)
    };

    private void Start()
    {
        IsWin = false;

        currentLocation = PlayerPrefs.GetInt("Save");
        gameObject.transform.position = locations[currentLocation];
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {           
            score.totalScore += 100;

            IsWin = true;

            levelchange.OnChangeLevel();
            PlayerPrefs.SetInt("Save", levelchange.currentLevel);
        }
    }
    private void Update()
    {
        if (buttonNextLevel.nextLevel)
        {
            currentLocation++;
            gameObject.transform.position = locations[currentLocation];

            map.ChangeMapPosition();

            time.totalTime = 0;
            score.totalScore = 0;

            nextLevel = true;
            wasWin = true;

            buttonNextLevel.nextLevel = false;
        }
        if (buttonRetry.retry && IsWin)
        {
            levelchange.OnRestartLevel();

            time.totalTime = 0;
            score.totalScore = 0;

            wasWin = true;

            buttonRetry.retry = false;
        }
    }
}
