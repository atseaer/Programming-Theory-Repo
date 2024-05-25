using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Cube : Shapes // INHERITANCE
{
    public TextMeshProUGUI text;
    private string m_speakWord = "I am strong!";

    protected void OnMouseDown()
    {
        ShapeName = "Cube";
        ShapeColor = "Red";
        DisplayText();
    }

    // POLYMORPHISM
    protected override void DisplayText()
    {
        StartCoroutine(Speak());
        base.DisplayText();
    }

    IEnumerator Speak()
    {
        text.text = m_speakWord;
        yield return new WaitForSeconds(3);
        text.text = "";
    }
}
