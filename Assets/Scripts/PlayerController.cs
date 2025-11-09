using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //movement
    //shooting
    //scope access modifier private or public
   
    
    
    private float playerSpeed;
    private float horizontalInput;
    private float verticalInput;

    private float horizontalScreenLimit = 9.5f;
    private float verticalScreenLimit = 5.5f;
    public GameObject bulletPrefab;




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        playerSpeed = 6f;  
    }

    // Update is called once per frame
    void Update()
    {
        //movement
        //shooting
        Movement();
        Shooting();
    }
    void Movement()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        //move the player
        transform.Translate(new Vector3(horizontalInput, verticalInput, 0) * Time.deltaTime * playerSpeed);
        //limit the player movment on screen
        if (transform.position.x > horizontalScreenLimit || transform.position.x < -horizontalScreenLimit)
        {
            transform.position = new Vector3(transform.position.x *-1, transform.position.y, 0);
        }

        if (transform.position.y >= 0f)
        {
            transform.position = new Vector3(transform.position.x, -verticalScreenLimit, 0);
        }
        else if (transform.position.y < -verticalScreenLimit)
        {

            transform.position = new Vector3(transform.position.x, 0f, 0);
        }
    }
    //shooting
    void Shooting()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            //spawn bullet
            Instantiate(bulletPrefab, transform.position + new Vector3(0, 1, 0), Quaternion.identity);
        }
    }
    public void LoseALife()
    {
        Debug.Log("Player lost a life!");
    }

}
