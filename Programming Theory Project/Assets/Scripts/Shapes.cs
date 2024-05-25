using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Shapes : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI m_clickText;

    private string m_shapeName;
    private string m_shapeColor;

    // ENCAPSULATION
    protected string ShapeName
    {
        get { return m_shapeName; }
        set { m_shapeName = value; }
    }

    protected string ShapeColor
    {
        get { return m_shapeColor; }
        set { m_shapeColor = value; }
    }
    
    // ABSTRACTION
    protected virtual void DisplayText()
    {
        m_clickText.text = "Clicked on " + m_shapeName + "; color: " + m_shapeColor;
    }


}
