using UnityEngine;

public class SphereAction : ObjectAction
{
    protected override void MoveObject()
    {
        if (transform.position.z < 0)
        {
            transform.position += new Vector3(0, 0, -0.02f);
        }
        else
        {
            transform.position += new Vector3(0, 0, -0.08f);
        }
    }
}
