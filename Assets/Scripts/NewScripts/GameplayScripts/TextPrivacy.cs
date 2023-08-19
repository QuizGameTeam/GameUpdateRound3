using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

namespace Gameplay
{
    public class TextPrivacy: MonoBehaviour , IPointerEnterHandler, IPointerExitHandler
    {
        public GameObject Pri;
        
        void Start()
        {
            Pri.SetActive(false);
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            Pri.SetActive(true);
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            Pri.SetActive(false);
        }
    }
}