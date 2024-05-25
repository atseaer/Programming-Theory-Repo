using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Sphere : Shapes // INHERITANCE
{
    public TextMeshProUGUI text;
    private string m_speakWord = "I am round!";

    protected void OnMouseDown()
    {
        ShapeName = "Sphere";
        ShapeColor = "Blue";
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
