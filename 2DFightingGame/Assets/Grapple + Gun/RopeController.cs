using System.Collections;
using UnityEngine;

public class RopeController : MonoBehaviour
{
    public GameObject ropeShooter;
    private int layerMask = ~(1 << 12);
    private SpringJoint2D rope;
    public int maxRopeFrameCount;
    private int ropeFrameCount;

    public LineRenderer lineRenderer;

    // Start is called before the first frame update
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 2))
            Debug.DrawLine(ray.origin, hit.point);

    }

    void LateUpdate()
    {
        if(rope != null)
        {
            lineRenderer.enabled = true;
            lineRenderer.SetVertexCount(2);
            lineRenderer.SetPosition(0, ropeShooter.transform.position);
            lineRenderer.SetPosition(1, rope.connectedAnchor);
        }
        else
        {
            lineRenderer.enabled = false;
        }
    }
 
    void FixedUpdate()
    {
        if (rope != null)
        {
            ropeFrameCount++;

            if (ropeFrameCount > maxRopeFrameCount)
            {
                GameObject.DestroyImmediate(rope);
                ropeFrameCount = 0;
            }
        }
    }

    void Fire()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 position = ropeShooter.transform.position;
        Vector3 direction = mousePosition - position;

        RaycastHit2D hit = Physics2D.Raycast(position, direction, 18, 1 << LayerMask.NameToLayer("world"));

        if(hit.collider != null)
        {
            SoundManager.PlaySound("grapple");
            SpringJoint2D newRope = ropeShooter.AddComponent<SpringJoint2D>();
            newRope.enableCollision = true;
            newRope.frequency = 1f;
            newRope.autoConfigureDistance = false;
            newRope.connectedAnchor = hit.point;
            newRope.distance = .75f;
            newRope.dampingRatio = .75f;
            newRope.enabled = true;

            GameObject.DestroyImmediate(rope);
            rope = newRope;
            ropeFrameCount = 0;

        }
    }
}
