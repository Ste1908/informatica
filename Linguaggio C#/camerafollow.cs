using UnityEngine;

public class camerafollow : MonoBehaviour
{
    public Transform target;
    private Vector3 offset;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      offset = transform.position - target.position;  
    }



    // Update is called once per frame
    void Update()
    {
        
    }


    private void LateUpdate()
    {
        transform.position = target.position + offset;
    }
}

