using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SimonSaysObject : MonoBehaviour
{
   public Color selectedColor;
   private Color originalColor; 
   public Button button;
   private Image buttonImage;

   private void Awake()
   {
       buttonImage = GetComponent<Image>();
       button = GetComponent<Button>();
       originalColor = buttonImage.color;
   }

    // Update is called once per frame
    public void SelectButton()
    {
        buttonImage.color = selectedColor;
        button.onClick.Invoke();
    }
    public void DeselectButton()
    {
        buttonImage.color = originalColor;
    }
}
