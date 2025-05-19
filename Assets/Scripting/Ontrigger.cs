
using UnityEngine;
using UnityEngine.UI;
public class Ontrigger : MonoBehaviour
{
    public Image check1;
    public Image img;
    public Image check2;
    private bool exit;
    public Image line;
    public Image line2;
    public SellCorn sellCorn;
    public bool complete1;
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (exit == true)
        {
            complete1 = true;
            if (img.enabled == true)
            {
                check1.enabled = true;
                line.enabled = true;

            }
            if (img.enabled == false)
            {
                check1.enabled = false;
                line.enabled = false;
            }
        }
        if (sellCorn.money >= 1)
        {
            if (exit == true)
            {
                if (img.enabled == true)
                {
                    check2.enabled = true;
                    line2.enabled = true;
                }
                if (img.enabled == false)
                {
                    check2.enabled = false;
                    line2.enabled = false;
                }
            }
        }
}
    private void OnTriggerEnter(Collider other)
    {
        exit = true;
    }

   
}
