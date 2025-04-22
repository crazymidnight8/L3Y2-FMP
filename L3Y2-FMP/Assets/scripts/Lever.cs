using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Lever : MonoBehaviour
{

    public bool isOn;
    public float LeverValue;
    public float LeverMax;

    public float moveSpeed;
    public Transform bridge;
    public Transform pointA;
    public Transform pointB;

    public Slider IsOff;

    // Start is called before the first frame update
    void Start()
    {
        isOn = false;
        LeverValue = 0f;
        LeverMax = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.GetComponent<Animator>().SetBool("leverOn", isOn);

        if (isOn)
        {
            bridge.position = Vector3.Lerp(bridge.position, pointB.position, moveSpeed * Time.deltaTime);
            LeverValue = 1f;
            IsOff.value = LeverValue;
        }
        else
        {
            bridge.position = Vector3.Lerp(bridge.position, pointA.position, moveSpeed * Time.deltaTime);
            LeverValue = 0f;
            IsOff.value = LeverValue;
        }
    }
}
