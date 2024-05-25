using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Cylinder : Shapes // INHERITANCE
{
    public TextMeshProUGUI text;
    private string m_speakWord = "I am tall!";

    protected void OnMouseDown()
    {
        ShapeName = "Cylinder";
        ShapeColor = "Green";
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
