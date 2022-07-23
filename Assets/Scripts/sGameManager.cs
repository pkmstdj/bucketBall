using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine.UI;

public class sGameManager : MonoBehaviour
{
    public TMP_Text txtScore; // 점수 텍스트
    public GameObject BallPrefeb; // 던질 공
    // Start is called before the first frame update
    void Start()
    {
        clk_Reset(); //처음에 점수 리셋으로 셋팅
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0) { // 터치 했나
            for(int i = 0 ; i < Input.touchCount ; i ++) { // 터치 갯수 모두
                Touch touch = Input.GetTouch(i);
                switch (touch.phase) {
                    case TouchPhase.Began: { // 터치 시작한 경우
                        if(!EventSystem.current.IsPointerOverGameObject(Input.GetTouch(i).fingerId)) { // UI 버튼 누른거 제외하고
                            GameObject ball = Instantiate(BallPrefeb, Camera.main.transform.position, Camera.main.transform.rotation) as GameObject; // 공 생성
                            ball.GetComponent<Rigidbody>().AddForce(Camera.main.transform.forward * 200); // 카메라 방향으로 발사
                        }
                        break;
                    }
                }
            }
        }
    }
    public void clk_Reset() // 점수 리셋 함수
    {
        txtScore.text = "" + 0; // 점수 0점으로
    }
}
