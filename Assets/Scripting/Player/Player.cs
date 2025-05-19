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

    public float gravity = -9.81f; // Gravity force
    public float jumpHeight = 2f; // If you want to allow jumping

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
            if (health < 1)
            {
                runiedFarm = true;
                SceneManager.LoadScene("Day3");
            }
        }

        // Update the slider with sprint time
        slider.value = sprintTime;
        slider.maxValue = purchaseButton.fix;

        // Handle movement and gravity
        HandleMovement();

    }

    public void AddMoveInput(float forwardInput, float rightInput)
    {
        // Get the forward and right directions based on camera rotation
        Vector3 forward = Camera.main.transform.forward;
        Vector3 right = Camera.main.transform.right;

        forward.y = 0f; // Ensure the Y value does not affect the movement
        right.y = 0f; // Same for right direction
        forward.Normalize();
        right.Normalize();

        // Combine the forward and right vectors with the input values
        moveDirection = (forward * forwardInput) + (right * rightInput);

        // Sprint time handling
        if (sprintTime <= 0)
        {
            sprintTime = 0;
            moveSpeed = 3; // Slow down the movement when out of sprint
        }

        // Handle upgrades and sprint time limits
        if (purchaseButton.Sold == false && purchaseButton.sold2 == false && purchaseButton.sold3 == false)
        {
            if (sprintTime >= 5) { sprintTime = 5; }
        }
        if (purchaseButton.Sold == true)
        {
            if (sprintTime >= 7) { sprintTime = 7; upgraded = true; }
        }
        if (purchaseButton.sold2 == true)
        {
            if (sprintTime >= 9) { sprintTime = 9; upgraded = true; }
        }
        if (purchaseButton.sold3 == true)
        {
            if (sprintTime >= 10) { sprintTime = 10; upgraded = true; }
        }

        // Handle sprinting logic
        if (Input.GetKey(KeyCode.LeftShift))
        {
            sprintTime -= minSprint * Time.deltaTime;
            isSprinting = true;
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            moveSpeed = sprintSpeed; // Increase speed when sprinting
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            moveSpeed -= 5f; // Decrease speed when not sprinting
            isSprinting = false;
        }
        else if (isSprinting == false)
        {
            Invoke("SprintRegan", 1f);
        }

        // Apply gravity effect
        moveDirection.y += gravity * Time.deltaTime; // Gravity should only affect Y
    }

    // Handle movement and apply gravity correctly
    private void HandleMovement()
    {
        // Apply movement based on the direction vector
        controller.Move(moveDirection * moveSpeed * Time.deltaTime);
    }

    void SprintRegan()
    {
        sprintTime += minSprint * Time.deltaTime;
    }
}