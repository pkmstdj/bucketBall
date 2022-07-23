using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sBucketPrefab : MonoBehaviour
{
    public GameObject bucketObject;
    Vector3 bucketPosition;
    // Start is called before the first frame update
    void Start()
    {
        bucketPosition = bucketObject.transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        bucketObject.transform.localPosition = bucketPosition + new Vector3(Mathf.Sin(Time.time * 4f) * .075f, .0f, .0f);
    }
}
