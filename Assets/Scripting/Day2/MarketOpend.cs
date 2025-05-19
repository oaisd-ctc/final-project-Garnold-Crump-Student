
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MarketOpend : MonoBehaviour
{
    public bool completed;
    public Image li;
    public Image l2;
    public Image c1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CLicked()
    {
        string current = SceneManager.GetActiveScene().name;
        if (current == "Day2")
        {
            completed = true;
        }
        if (completed == true)
        {
            li.enabled = true;
            l2.enabled = true;
            c1.enabled = true;
        }
    }
}
