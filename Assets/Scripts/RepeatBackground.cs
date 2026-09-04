using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    // this for decralation the start position
    private Vector3 startPos;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private float repeatwith;
    void Start()
    {
        // and this for set value 
        startPos = transform.position;
        repeatwith = GetComponent<BoxCollider>().size.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        // and this for repeating
        if (transform.position.x < startPos.x - repeatwith)
            transform.position = startPos;
    }
}
