using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
   
    [SerializeField] private float jumpForce = 5f; // Forza del salto
    [SerializeField] private bool isGrounded;      // Verifica se a terra
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Controlla se il tasto Spazio è premuto e se siamo a terra
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            // Applica forza verticale istantanea (Impulse)
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            isGrounded = false; // Il giocatore è ora in aria
        }
    }

    // Rileva collisione con il suolo
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true; // Il giocatore ha toccato il suolo
        }
    }
}

