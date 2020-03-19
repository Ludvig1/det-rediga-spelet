using UnityEngine;

public class Camerafollow : MonoBehaviour {

    public Transform Target;

    public float smoothspeed = 0.125f;
    public Vector3 offset;

    void LateUpdate ()
    {
        transform.position = Target.position + offset; 
    }

}
