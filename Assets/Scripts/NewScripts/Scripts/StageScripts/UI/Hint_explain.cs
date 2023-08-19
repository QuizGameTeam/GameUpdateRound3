using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

namespace UI
{
    public class Hint_explain: MonoBehaviour , IPointerEnterHandler, IPointerExitHandler
    {
        public GameObject Hint;
        
        void Start()
        {
            Hint.SetActive(false);
            Debug.Log("Lock");
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            Hint.SetActive(true);
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            Hint.SetActive(false);
        }
    }
}