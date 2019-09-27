using UnityEngine;
using UnityEngine.EventSystems;


public class CameraMovement : MonoBehaviour
{

    [SerializeField]
    private float cameraSpeed = 0;

    [SerializeField]
    private float zoomSpeed = 0.01f;

    [SerializeField]
    private float zoomOutMin = 1;

    [SerializeField]
    private float zoomOutMax = 2;

    private float xMax;
    private float yMin;

    // Update is called once per frame
    void Update()
    {
        getInput();
    }

    private void getInput()
    {

        if (Input.touchCount > 0 && !EventSystem.current.IsPointerOverGameObject(Input.GetTouch(0).fingerId))
        {
            if (Input.touchCount == 2)
            {

                Touch touchZero = Input.GetTouch(0);
                Touch touchOne = Input.GetTouch(1);

                Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
                Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

                float currentMagnitude = (touchZero.position - touchOne.position).magnitude;
                float prevMagnitude = (touchZeroPrevPos - touchOnePrevPos).magnitude;

                float difference = currentMagnitude - prevMagnitude;

                Zoom(difference * zoomSpeed);

            }
            else if (Input.touchCount == 1 && Input.GetTouch(0).phase == TouchPhase.Moved)
            {

                transform.Translate(-Input.GetTouch(0).deltaPosition * cameraSpeed);

                Camera.main.transform.position = new Vector3(Mathf.Clamp(Camera.main.transform.position.x, 0, 0.3f),
                    Mathf.Clamp(Camera.main.transform.position.y, -1.2f, 0), -10);

            }
        }

    }

    public void Zoom(float increment)
    {
        Camera.main.orthographicSize = Mathf.Clamp(Camera.main.orthographicSize - increment, zoomOutMin, zoomOutMax);
    }




    public void setLimits(Vector3 maxTile)
    {
        Vector3 worldPosition = Camera.main.ViewportToWorldPoint(new Vector3(1, 0));

        xMax = maxTile.x - worldPosition.x;
        yMin = maxTile.y - worldPosition.y;

    }

}
