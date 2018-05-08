using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System;
using UnityEngine.UI;
public class MouseControl : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject obj;
    private bool _isEnter;
    private float _timer;


    // public String methodName;

   // public GameObject gameManager;
    public GameObject buttonComponent;
    public int methodID;

    void Update()
    {

        _timer += Time.deltaTime;

        //Debug.Log("触摸计时");
        if (_isEnter && _timer - 2.0f > 0f)
        {
          //  obj.SetActive(true);
            Debug.Log("触摸开始");

          //  gameManager.GetComponent<GameManager>().OnStartGame();
            buttonComponent.GetComponent<ScenesManager>().SendMessage("methodSelectWithID", methodID);

        }
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        _timer = 0;
        _isEnter = true;
        Debug.Log("触摸进入");

        
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        _isEnter = false;
       // obj.SetActive(false);
        Debug.Log("触摸退出");
    }
}