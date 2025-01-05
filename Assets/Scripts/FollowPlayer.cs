using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform playerTransform;
    public float offset;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cemraPos = transform.position;
        cemraPos.z = playerTransform.position.z + offset;
        transform.position = cemraPos;
    }
}
