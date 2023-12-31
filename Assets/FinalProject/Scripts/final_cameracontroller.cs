using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class final_cameracontroller : MonoBehaviourPunCallbacks
{
    public Camera playerCamera; // 플레이어의 카메라를 연결할 오브젝트
    public Slider healthSlider;
    public TMP_Text PlayerName;


    private void Start()
    {
        if (photonView.IsMine)
        {
            // 자신의 플레이어인 경우
            playerCamera.enabled = true; // 플레이어의 카메라를 활성화
            healthSlider.gameObject.SetActive(true);
            PlayerName.enabled = true;
        }
        else
        {
            // 다른 플레이어인 경우
            playerCamera.enabled = false; // 플레이어의 카메라를 비활성화
            healthSlider.gameObject.SetActive(false);
            PlayerName.enabled = false;
        }
    }

    private void Update()
    {
        if (photonView.IsMine)
        {
            // 자신의 플레이어인 경우
            playerCamera.enabled = true; // 플레이어의 카메라를 활성화
            healthSlider.gameObject.SetActive(true);
            PlayerName.enabled = true;
        }
        else
        {
            // 다른 플레이어인 경우
            playerCamera.enabled = false; // 플레이어의 카메라를 비활성화
            healthSlider.gameObject.SetActive(false);
            PlayerName.enabled = false;
        }
        /*
        if (!photonView.IsMine)
        {
            // 다른 플레이어인 경우
            return; // 카메라 업데이트 중지
        }
        */
    }
}
