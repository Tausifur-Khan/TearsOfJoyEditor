using UnityEngine;
using System.Collections;

public class Orbit : MonoBehaviour
{
    
    public Transform target;
    public Vector3 offset = new Vector3(0, 1f, 0);
    public float maxDistance = 5.0f;
    public float xSpeed = 120.0f;
    public float ySpeed = 120.0f;

    public float yMinLimit = -20f;
    public float yMaxLimit = 80f;

    public float distanceMin = .5f;
    public float distanceMax = 15f;

    [Header("Collision")]
    public bool cameraCollision = false;
    public float camRadius = 1f;
    public float rayDistance = 1000f;
    public LayerMask ignoreLayers;

    private Vector3 originalOffset;
    private float distance = 5.0f;
    private float x = 0.0f;
    private float y = 0.0f;


    // Use this for initialization
    void Start()
    {
        //Calculate offset of camera at start
        originalOffset = transform.position - target.position;
        //Ray distance is as long as the magnitude of offset
        rayDistance = originalOffset.magnitude;

        Vector3 angles = transform.eulerAngles;
        x = angles.y;
        y = angles.x;

        transform.SetParent(null);

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }


    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawWireSphere(transform.position, camRadius);
    }
    void FixedUpdate()
    {
        if (target)
        {
            if (cameraCollision)
            {
                //Creat camera ray from the starting position
                //Goes backwards from target
                Ray camRay = new Ray(target.position, -transform.forward);
                RaycastHit hit;
                if(Physics.SphereCast(camRay, camRadius, out hit, rayDistance, ~ignoreLayers, QueryTriggerInteraction.Ignore))
                {
                    distance = hit.distance;
                    //return - exit the function
                    return;
                }
            }

            //Reset Distance if not hitting
            distance = originalOffset.magnitude;
        }
    }
    public void Look(float mouseX, float mouseY)
    {
        x += mouseX * xSpeed * Time.deltaTime;
        y -= mouseY * ySpeed * Time.deltaTime;

        y = ClampAngle(y, yMinLimit, yMaxLimit);

        Quaternion rotation = Quaternion.Euler(y, x, 0);
        transform.rotation = rotation;
    }
    void LateUpdate()
    {
        if (target)
        {
            //Convert to world to local 
            Vector3 localOffset = transform.TransformDirection(offset);
            transform.position = (target.position + offset) + -transform.forward * distance;
        }
    }

    public static float ClampAngle(float angle, float min, float max)
    {
        if (angle < -360F)
            angle += 360F;
        if (angle > 360F)
            angle -= 360F;
        return Mathf.Clamp(angle, min, max);
    }
}