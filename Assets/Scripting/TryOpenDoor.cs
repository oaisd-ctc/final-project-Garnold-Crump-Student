
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class TryOpenDoor : MonoBehaviour
{ public GameObject player;
    public GameObject enemy;
    float maxDistance = 2f;
    [SerializeField] private string scene;
    [SerializeField] private Text text3;
    [SerializeField] private Text text4;
    [SerializeField] private Text text5;
    public string sceneName2;
    private bool b2;
    private bool b1;
    public RawImage rawImage ;
    string gone = "";
    string locked = "The Door is Locked";

    string behind = "Dont Look Behind You";
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            if (Vector3.Distance(transform.position, player.transform.position) <= maxDistance)
            {
               if(Input.GetKey(KeyCode.E)) {
                    text3.text = locked;
                    Invoke("DisableText3", 1f);
                    Invoke("Behind", 0.5f);
                    Invoke("DisableText4", 2f);
                    

                }
               else if (Input.GetKey(KeyCode.E))  text5.text = gone; 
            }
        }
    }
    void DisableText3()
    {
        text3.enabled = false;
        b1 = true;
    }
        void Behind()
    {
        if (b1 == true)
        {
            text4.text = behind;
            b1 = false;
        }
        else { Debug.Log("Didn't work"); }
        
        if (b1 == false)
        {
            Invoke("EnemyEnable", 1f);
            Invoke("EnableImage", 1.5f);
            Invoke("LoadScene", 1.7f);
        }
        if(b2 == false)
        {
            Invoke("LoadScene2", 1f);
        }
    }
    void DisableText4()
    {
        text4.enabled = false;
        b2 = false;
    }
    void EnableImage()
    {
       
        rawImage.enabled = true; 
       
    }
    void LoadScene2()
    {
        Debug.Log("Didnt wprl");
    }
    void EnemyEnable()
    {
        enemy.SetActive(true);
    }
    void LoadScene()
    {
        SceneManager.LoadScene(sceneName2);
    }

}
