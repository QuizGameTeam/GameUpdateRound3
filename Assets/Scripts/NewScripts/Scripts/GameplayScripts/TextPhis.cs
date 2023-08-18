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
    public class TextPhis: MonoBehaviour , IPointerEnterHandler, IPointerExitHandler
    {
        public GameObject Phis;
        
        void Start()
        {
            Phis.SetActive(false);
        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            Phis.SetActive(true);
        }

        public void OnPointerExit(PointerEventData eventData)
        {
            Phis.SetActive(false);
        }
    }
}