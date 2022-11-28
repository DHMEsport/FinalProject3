using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextEffect : MonoBehaviour
{
  [SerializeField] private float speed;
  [SerializeField] private string Fulltext;
   private string Currenttext;
  [SerializeField] private TextMeshProUGUI text;
  private void Start()
  {
    StartCoroutine(Showtext());
    Debug.Log("Text is now showing");
  }

  IEnumerator Showtext()
  {
    for (int i = 0; i < Fulltext.Length; i++)
    {
      Currenttext = Fulltext.Substring(0, i);
      text.GetComponent<TextMeshProUGUI>().text = Currenttext;
      yield return new WaitForSeconds(speed);
    }
  }
}
