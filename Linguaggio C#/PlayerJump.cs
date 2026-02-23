using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerJump : MonoBehaviour
{
    public float jumpForce = 5f; // Forza del salto
    public bool isGrounded;      // Verifica se il giocatore tocca terra
    public float groundCheckDistance = 0.2f; // Distanza per raycast
    public LayerMask groundMask; // Layer del terreno

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Controlla se il giocatore è a terra (usando un piccolo Raycast verso il basso)
        isGrounded = Physics.Raycast(transform.position, Vector3.down, groundCheckDistance, groundMask);

        // Se premi Spazio e sei a terra, salta
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            // Applica forza verso l'alto (ForceMode.Impulse è ottimo per salti istantanei)
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}


