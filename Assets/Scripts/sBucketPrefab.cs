using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sBucketPrefab : MonoBehaviour
{
    public GameObject bucketObject; // 바구니 게임오브젝트
    Vector3 bucketPosition; // 바구니 시작위치
    // Start is called before the first frame update
    void Start()
    {
        bucketPosition = bucketObject.transform.localPosition; // 바구니 시작위치 저장
    }

    // Update is called once per frame
    void Update()
    {
        bucketObject.transform.localPosition = bucketPosition + new Vector3(Mathf.Sin(Time.time * 4f) * .075f, .0f, .0f); // 바구니 좌우로 반복 4의 속도로 .075f만큼
    }
}
