using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BoxController : MonoBehaviour {

    [Header("Max angle of rotated object")]
    [Range(0, 90)]
    public float maxRotationAngle = 45;

    [Header("Smooth")]
    [Range(0,100)]
    public int smoothParameter = 30;

    [Header("Smooth")]
    [Range(0, 10000)]
    public int objectMinDistanse = 500;

    [Header("Smooth")]
    [Range(0, 10000)]
    public int objectMaxDistanse = 2000;

    [Range(1f, 2f)]
    public float rotateMultiplier = 2;


    [Range(1f, 100f)]
    public float moveXYMultiplier = 10;

    [Range(1f, 100f)]
    public float moveZMultiplier = 10;

    public GameObject positionController;
    Queue<Vector3> positions;
    Queue<Vector3> rotationsDeg;
   

    // Use this for initialization
    void Start () {
        positionController = GameObject.Find("ARObjects");
        positions = new Queue<Vector3>();
        rotationsDeg = new Queue<Vector3>();
    }
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyDown(KeyCode.Escape)) Application.Quit();
        Vector3 rot = SmoothedRotation(positionController.transform.forward);
        transform.rotation = Quaternion.LookRotation(rot);
        transform.position = SmoothedPosition(positionController.transform.position);

        

    }

    Vector3 SmoothedPosition(Vector3 position) {
        if (positions.Count > smoothParameter) positions.Dequeue();
        positions.Enqueue(position);

        Vector3 pos = Vector3.zero;
        foreach (Vector3 v in positions) pos += v;
        pos /= positions.Count;
        pos.x = pos.x*moveXYMultiplier;
        pos.y = pos.y*moveXYMultiplier;
        pos.z =  pos.z*moveZMultiplier;
        Vector3 clampPos = new Vector3(Mathf.Clamp(pos.x, -2000, 2000), Mathf.Clamp(pos.y, -1600, 600), Mathf.Clamp(pos.z, -8000, -400));
        return clampPos;
    }

    Vector3 SmoothedRotation(Vector3 rotation)
    {
        if (rotationsDeg.Count > smoothParameter) rotationsDeg.Dequeue();
        rotationsDeg.Enqueue(rotation);
        Vector3 rot = Vector3.zero;
        foreach (Vector3 v in rotationsDeg) rot+=v;
        rot /= rotationsDeg.Count;
        rot *= rotateMultiplier;
        rot.x = Mathf.Clamp(-rot.x, -maxRotationAngle, maxRotationAngle);
        rot.y = Mathf.Clamp(-rot.y, -maxRotationAngle, maxRotationAngle);
        return rot;
    }
}
