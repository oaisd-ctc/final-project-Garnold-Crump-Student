
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Player : MonoBehaviour
{
    CharacterController controller;
    public float moveSpeed = 5f;
    public float sprintSpeed = 8f;
    private Vector3 moveDirection;
   public float sprintTime = 5f;
    private float minSprint = 0.8f;
    public bool isSprinting;
    public Slider slider;
    public PurhcaseButton purchaseButton;
    public GameObject player;
    public string SceneName;
    public bool upgraded;
    public float health = 1f;
    public bool runiedFarm;
    public Vector3 mover;
   
  
   


   
      
 
    void Start()
    {
       string current = SceneManager.GetActiveScene().name;
        controller = GetComponent<CharacterController>();
        if (current == "Title") { DontDestroyOnLoad(player); }
        
    }

    // Update is called once per frame
    void Update()
    {
       string current = SceneManager.GetActiveScene().name;
        if (current == "Day2")
        {
            if(health < 1)
            {
                runiedFarm = true;
                SceneManager.LoadScene("Day3");
            }
        }


   
        slider.value = sprintTime;
        slider.maxValue = purchaseButton.fix;
        moveDirection.Normalize();
        moveDirection.y = -1f;

        controller.Move(moveDirection * moveSpeed * Time.deltaTime);

    }
    public void AddMoveInput(float forwardInput, float rightInput)
    {
        Vector3 forward = Camera.main.transform.forward;
        Vector3 right = Camera.main.transform.right;

        forward.y = 0f;
        right.y = 0f;

        forward.Normalize();
        right.Normalize();
        moveDirection = (forward * forwardInput) + (rightInput * right);
        
        if(sprintTime <= 0)
        {
            sprintTime = 0;
            moveSpeed = 3;
        }
        if (purchaseButton.Sold == false && purchaseButton.sold2 == false && purchaseButton.sold3 == false) { if (sprintTime >= 5) { sprintTime = 5; } 
        }
        if(purchaseButton.Sold == true) {  if (sprintTime >= 7) { sprintTime = 7; upgraded = true; } }
        if(purchaseButton.sold2 == true) {if(sprintTime >= 9) {  sprintTime = 9; upgraded = true; } }
        if(purchaseButton.sold3 == true) { if(sprintTime >= 10) {  sprintTime = 10; upgraded = true; } }
    
        if (Input.GetKey(KeyCode.LeftShift))
        {
            sprintTime -= minSprint * Time.deltaTime;
            isSprinting = true;

        }
      
       
        if (Input.GetKeyDown(KeyCode.LeftShift)) {
             moveSpeed =  sprintSpeed;
          
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            moveSpeed -= 5f;
            isSprinting = false;
        }
        else if (isSprinting == false)
        {
            Invoke("SprintRegan", 1f);
        }
        
    }

    void SprintRegan()
    {
        sprintTime += minSprint * Time.deltaTime;
    }
    
    
    
}
