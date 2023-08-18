
using UnityEngine;

public class GameplayScripts : MonoBehaviour
{
    public string name = "Jumper";
    // Start is called before the first frame update
    [SerializeField] private AudioSource src;
    [SerializeField] private AudioClip AudioPlay;
    

    void Start()
    {
        src.clip = AudioPlay;
        src.loop = true;
        src.Play();
        
        name = PlayerPrefs.GetString("name");
        
        if (name == "Jumper")
        {
            GameObject.Find("Flyer").SetActive(false);
            GameObject.Find("Runner").SetActive(false);
        }
        else if (name == "Runner")
        {
            GameObject.Find("Flyer").SetActive(false);
            GameObject.Find("Jumper").SetActive(false);
        }
        else if (name == "Flyer")
        {
            GameObject.Find("Runner").SetActive(false);
            GameObject.Find("Jumper").SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
