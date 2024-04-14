using UnityEngine;

public class MusicBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    public new AudioSource audio;
    public AudioClip[] clip;
    private int Index;

    private static GameObject instance;
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        if (instance == null)
            instance = gameObject;
        else
            Destroy(gameObject);

        audio.clip = clip[0];
        audio.Play();
    }

    private void Update()
    {
        audio.volume = PlayerPrefs.GetFloat("MusicVolume");

        if (!audio.isPlaying)
        {
            Index++;

            if (Index > 9)
            {
                Index = 0;
            }

            audio.clip = clip[Index];
            audio.Play();       
        }
    }
}
