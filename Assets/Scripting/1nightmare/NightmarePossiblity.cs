
using UnityEngine;
using UnityEngine.SceneManagement;

public class NightmarePossiblity : MonoBehaviour
{
   [SerializeField] int randomNum;
    public GameObject player;
   private string Day3 = "Day3";
    private string Scary1 = "NightMare1";
        private string Scary2 = "NightMare2";
        private string Scary3 = "NightMare3";
    private string Scary4 = "NightMare4";
    private string Scary5 = "NightMare5";
    private bool Loaded;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(transform.position, player.transform.position) <= 4){
            if (Input.GetKeyDown(KeyCode.E)) {
                CreateRandomNumber(); }
        }
        if(randomNum == 1)
        { Invoke("LoadScene1", 0f); }
        if(randomNum == 2)
        { Invoke("LoadScary1", 0f); }
        if(randomNum == 3) { Invoke("LoadScary2", 0f); }
        if(randomNum == 4) { Invoke("LoadScene1", 0f); }
        if(randomNum == 5) { Invoke("LoadScene1", 0f); }
        if(randomNum == 6) { Invoke("LoadScary4", 0f); }
        if (randomNum == 7) { Invoke("LoadScary5", 0f); }
        if(randomNum == 8) { Invoke("LoadScene1", 0f); }
        if(randomNum == 9) { Invoke("LoadScene1", 0f); }
        if (randomNum == 10) { Invoke("LoadScary3", 0f); }
        if(randomNum == 11) {  Invoke("LoadScene1", 0f); }
        if(randomNum == 12) {  Invoke("LoadScene1", 0f); }
        {
            
        }
        {
            
        }


    }

    private void CreateRandomNumber()
    {
        randomNum = Random.Range(1, 12);
    }
    void LoadScene1()
    {
        SceneManager.LoadScene(Day3); Loaded = true;
        if(Loaded == true) { randomNum = 0; }
        
    }
    void LoadScary1()
    {
        SceneManager.LoadScene(Scary1); Loaded = true;
        if(Loaded == true) { randomNum = 0; }
    }
    void LoadScary2()
    {
        SceneManager.LoadScene(Scary2); Loaded = true;
        if (Loaded == true) { randomNum = 0; }
    }
    void LoadScary3()
    {
        SceneManager.LoadScene(Scary3); Loaded = true;
        if (Loaded == true) { randomNum = 0; }
    }
    void LoadScary4()
    {
        SceneManager.LoadScene(Scary4); Loaded = true;
        if (Loaded == true) { randomNum = 0; }
    }
    void LoadScary5()
    {
        SceneManager.LoadScene(Scary5); Loaded = true;
        if (Loaded == true) { randomNum = 0; }
    }

}
