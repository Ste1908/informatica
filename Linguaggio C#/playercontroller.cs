using UnityEngine;
using TMPro;
public class playercontroller : MonoBehaviour
{
    public float palyerspeed;
    private Rigidbody rb;
    private int count = 0;

public TextMeshProUGUI Score;
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
}
