using UnityEngine;
using TMPro;
public class playercontroller : MonoBehaviour
{
    public float palyerspeed;
    private Rigidbody rb;
    private int count = 0;
    private double time = 5.60;
    public GameObject respawnpos;
    public GameObject[] collectibles;

public TextMeshProUGUI Score;
    public TextMeshProUGUI Time;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveX, 0, moveZ);
        rb.AddForce(movement * palyerspeed);
    }


    // Update is called once per frame
    void Update()
    {
        time = time - 0.000020;
        Time.text = "Time: " + time;

       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);
            count++;
            print("Punteggio: " + count);
Score.text = "Score: " + count;

        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("NPC"))
        {
            transform.position = respawnpos.transform.position;
            count = 0;
            Score.text = "Score: " + count;
            foreach ( GameObject collectible in collectibles)
            {
                collectible.SetActive(true);
            }
        }
    }
}
