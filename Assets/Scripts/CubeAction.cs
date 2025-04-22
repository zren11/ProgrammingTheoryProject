using UnityEngine;

// INHERITANCE
public class CubeAction : ObjectAction
{
    // POLYMORPHISM
    protected override void MoveObject()
    {
        if (transform.position.z < 0)
        {
            transform.position += new Vector3(0, 0, -0.06f);
        }
        else
        {
            transform.position += new Vector3(0, 0, -0.02f);
        }
    }
}
