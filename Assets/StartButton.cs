using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// ���C�u�����̒ǉ�
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class startButton : MonoBehaviour
{
    void Start() { gameObject.GetComponent<Button>().onClick.AddListener(StartGame); }
    void StartGame() { SceneManager.LoadScene("Sample Scene"); }
}