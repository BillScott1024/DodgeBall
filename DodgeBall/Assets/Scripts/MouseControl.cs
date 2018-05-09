using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System;
using UnityEngine.UI;
public class MouseControl : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
   // public GameObject obj;
    private bool _isEnter;
    private float _timer;


    // public String methodName;

   // public GameObject gameManager;
    public GameObject gameManager;
   // public Animator cursor;
    public int methodID;
    public GameObject cursor;
   // private bool m_cursor = false;
    void Update()
    {

        _timer += Time.deltaTime;

        //Debug.Log("触摸计时");
        if (_isEnter && _timer - 2.0f > 0f)
        {
          //  obj.SetActive(true);
            Debug.Log("触摸开始");
           // cursor.transform.position = Input.mousePosition;
            //if (m_cursor == false)
            //{
            //    cursor.SetBool("anim_cursor", false);
            //}
            //if(m_cursor == true)
            //{
            //    cursor.SetBool("anim_cursor", true);
            //}
            

            //  gameManager.GetComponent<GameManager>().OnStartGame();
            gameManager.GetComponent<ScenesManager>().SendMessage("methodSelectWithID", methodID);

        }
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        _timer = 0;
        _isEnter = true;
        cursor.GetComponent<Animation>().Play();
        Debug.Log("触摸进入");

        
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        _isEnter = false;
        // obj.SetActive(false);

        Debug.Log("触摸退出");
    }
}