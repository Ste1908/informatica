using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class NPCBehavior : MonoBehaviour
{
    public float speed = 2.0f; 
    public Transform player;
    public float followDistance = 100000.0f;
    public float stopDistance = 0.0f;
    private CharacterController controller;
    public GameObject respawnpos;
    private enum NPCState { Idle, Patrol, Chase }
    private NPCState currentState = NPCState.Idle;
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player == null) return;
        float distance = Vector3.Distance(transform.position, player.position);
        if (distance > stopDistance && distance < followDistance)
        {
            Vector3 direction = (player.position - transform.position).normalized;
            direction.y = 0;
            controller.Move(direction * speed * Time.deltaTime);
            transform.LookAt(new Vector3(player.position.x, player.position.y, player.position.z));
            switch (currentState)
            {
                case NPCState.Idle:
                   
                    break;
                case NPCState.Chase:
                   
                    break;
            }
        }
    }
}
