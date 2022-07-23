using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class sBucketCollider : MonoBehaviour
{
    public TMP_Text txtScore; // 점수 텍스트
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "ball") { // 테그로 공 확인
            txtScore.text = "" + (Int32.Parse(txtScore.text) + 1); // 점수 상승 하고
            Destroy(other.gameObject); // 공삭제
        }
    }
}
