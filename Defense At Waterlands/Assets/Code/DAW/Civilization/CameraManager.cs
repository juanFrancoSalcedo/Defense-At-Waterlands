using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [SerializeField] private Transform cam = null;
    [SerializeField] ZoomCamera cameraZoom = new ZoomCamera();
    [SerializeField] MovementCamera cameraMovement = new MovementCamera();
    [SerializeField] CameraOrtographic ortographicSettings = new CameraOrtographic();
    [SerializeField] CameraPerspective perspectiveSettings = new CameraPerspective();
    [SerializeField] private bool isOrtographic = true;

    private new Camera camera = null;

    private void Start() => camera = cam.GetComponent<Camera>();

    void Update()
    {
        cameraZoom.CalculateZoom(camera);
        cameraMovement.CalculateMovement(cam);
    }

    [ContextMenu("Set camera")]
    public void SetCamera() 
    {
        if(!camera)
            camera = cam.GetComponent<Camera>();
        CameraDAW cameraNew = (isOrtographic) ? ortographicSettings : perspectiveSettings;
        cameraNew.SetCamera(camera);
    }


    [System.Serializable]
    public class ZoomCamera 
    {
        [SerializeField] private float amount;
        public void CalculateZoom(Camera cam) 
        {
            var buffer = cam.transform.position;
            if (cam.orthographic)
            {
                buffer.y = cam.orthographicSize;
                buffer.y -= Input.mouseScrollDelta.y * amount;
                cam.orthographicSize = buffer.y;
            }
            else
            { 
                buffer.y -= Input.mouseScrollDelta.y * amount;
                cam.transform.position = buffer;
            }
        }
    }

    [System.Serializable]
    public class MovementCamera
    {
        [SerializeField] private float amount = 0;
        private float constraint = 10;
        public void CalculateMovement(Transform target)
        {
            var buffer = target.transform.position;
            if (Input.mousePosition.x > Screen.width - constraint)
            {
                buffer.x += amount;
            }
            if (Input.mousePosition.x < constraint)
            {
                buffer.x -= amount;
            }
            if (Input.mousePosition.y > Screen.height - constraint)
            {
                buffer.z += amount;
            }
            if (Input.mousePosition.y < constraint)
            {
                buffer.z -= amount;
            }
            target.transform.position = buffer;
        }
    }

    [System.Serializable]
    public class CameraOrtographic : CameraDAW
    {
        [field: SerializeField] protected override Vector3 RotationCamera { get ; set; }
        [field: SerializeField] protected override Vector3 InitPosition { get; set; }

        public override void SetCamera(Camera camera)
        {
            camera.orthographic = true;
            camera.orthographicSize = InitPosition.y;
            camera.transform.rotation = Quaternion.Euler(RotationCamera);
        }
    }

    [System.Serializable]
    public class CameraPerspective : CameraDAW
    {
        [field:SerializeField] protected override Vector3 RotationCamera { get; set; }
        [field: SerializeField] protected override Vector3 InitPosition { get; set; }

        public override void SetCamera(Camera camera)
        {
            camera.orthographic = false;
            camera.transform.SetPositionAndRotation(InitPosition,Quaternion.Euler(RotationCamera));
        }
    }

    public abstract class CameraDAW 
    {
        public abstract void SetCamera(Camera camera);
        protected abstract Vector3 RotationCamera { get; set; }
        protected abstract Vector3 InitPosition { get; set; }
    }
}
