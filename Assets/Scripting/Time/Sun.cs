
using UnityEngine;
using UnityEngine.UI;

public class Sun : MonoBehaviour
{
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(Vector3.zero, Vector3.right,0.8f*Time.deltaTime);
        transform.LookAt(Vector3.zero);

        
    }
}
