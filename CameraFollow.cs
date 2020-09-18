using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject followObject;
    public Vector2 followOffset;
    private Vector2 threshold;
    // Start is called before the first frame update
    void Start()
    {
        threshold = calculateThreshold();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 follow = followObject.transform.position;
        float XDiffrence = Vector2.Distance(Vector2.right * transform.position.x, Vector2.right * follow.x);
        float YDiffrense = Vector2.Distance(Vector2.up * transform.position.y, Vector2.up * follow.y);
    }
    private Vector3 calculateThreshold()
    {
        Rect aspect = Camera.main.pixelRect; // define our aspeect ratio
        Vector2 t = new Vector2(Camera.main.orthographicSize * aspect.width / aspect.height, Camera.main.orthographicSize); // find out the heightth and width of our screen boundury box
        t.x -= followOffset.x;
        t.y -= followOffset.y;
        return t;
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Vector2 border = calculateThreshold();
        Gizmos.DrawWireCube(transform.position, new Vector3(border.x * 2, border.y * 2, 1));
    }
}
