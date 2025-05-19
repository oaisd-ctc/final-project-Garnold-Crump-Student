using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Start1 : MonoBehaviour
{
    public Image Image;
    public Text Text;
    public Text Text2;
    public GameObject gameObject2;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("enable", 3f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
Image.enabled = false;
            Text.enabled = false;
            Text2.enabled = false;
        }
    }
    void enable()
    {
        Text2.enabled=true;
    }
    public void OnClick()
    {

    }
}
