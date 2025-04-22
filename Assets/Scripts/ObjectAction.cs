using UnityEngine;

public class ObjectAction : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        MoveObject();
        if (transform.position.z < -5)
        {
            Destroy(gameObject);
        }
    }

    protected virtual void MoveObject()
    {
        transform.position += new Vector3(0, 0, -0.01f);
    }

}
