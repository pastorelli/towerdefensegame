using UnityEngine;

public class CameraController : MonoBehaviour {

    public float panSpeed = 30f;
    public float panBorderThikcness = 10f;
    public float scrollSpeed = 5f;
    public float minY = 10f;
    public float maxY = 80f;


    private bool doMovement = true;




    // Update is called once per frame
    void Update () {

        if (Input.GetKeyDown(KeyCode.Escape))
            doMovement = !doMovement;

        if (!doMovement)
            return;

        if (Input.GetAxis("Vertical") > 0 || Input.mousePosition.y >= Screen.height - panBorderThikcness)
        {
            transform.Translate(Vector3.forward * panSpeed * Time.deltaTime, Space.World);
        }
        if (Input.GetAxis("Vertical") < 0 || Input.mousePosition.y <= panBorderThikcness)
        {
            transform.Translate(Vector3.back * panSpeed * Time.deltaTime, Space.World);
        }
        if (Input.GetAxis("Horizontal") > 0 || Input.mousePosition.x >= Screen.width - panBorderThikcness)
        {
            transform.Translate(Vector3.right * panSpeed * Time.deltaTime, Space.World);
        }
        if (Input.GetAxis("Horizontal") < 0 || Input.mousePosition.x <= panBorderThikcness)
        {
            transform.Translate(Vector3.left * panSpeed * Time.deltaTime, Space.World);
        }

        float scroll = Input.GetAxis("Mouse ScrollWheel");

        Vector3 pos = transform.position;

        pos.y -= scroll * 1000 * scrollSpeed * Time.deltaTime;
        pos.y = Mathf.Clamp(pos.y, minY, maxY);
        transform.position = pos;
    }
}
