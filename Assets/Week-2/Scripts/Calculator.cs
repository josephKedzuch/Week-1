using UnityEngine;
using TMPro;

public class Calculator : MonoBehaviour
{
    float prevInput = 0;
    bool clearPrevInput = false;
    public TextMeshProUGUI label;
    private EquationType equationType;

    private void Start()
    {
        label.text = string.Empty;
    }

    public void AddInput(string input)
    {
        if (clearPrevInput == true){
            label.text = string.Empty;
            clearPrevInput = false;
        }
        label.text = label.text + input;
    }

    public void SetEquationAsAdd()
    {
        prevInput = float.Parse(label.text);
        clearPrevInput = true;
        equationType = EquationType.ADD; 
        
    }
    public void SetEquationAsSubtract()
    {
        prevInput = float.Parse(label.text);
        clearPrevInput = true;
        equationType = EquationType.SUBTRACT; 
        
    }
    public void SetEquationAsMultiply()
    {
        prevInput = float.Parse(label.text);
        clearPrevInput = true;
        equationType = EquationType.MULTIPLY; 
        
    }
    public void SetEquationAsDivide()
    {
        prevInput = float.Parse(label.text);
        clearPrevInput = true;
        equationType = EquationType.DIVIDE; 
        
    }
    public void Add()
    {
        float total = prevInput + float.Parse(label.text);
        label.text = total.ToString();
        
    }

    public void Subtract()
    {
        float total = prevInput - float.Parse(label.text);
        label.text = total.ToString();
        
    }


    public void Multiply()
    {
        float total = prevInput * float.Parse(label.text);
        label.text = total.ToString();
        
    }


    public void Divide()
    {
        float total = prevInput / float.Parse(label.text);
        label.text = total.ToString();
        
    }


    public void Clear()
    {
        label.text = string.Empty;
        prevInput = 0;
        equationType = EquationType.None;        
    }

    public void Calculate()
    {
        if (equationType == EquationType.ADD) Add();
        if (equationType == EquationType.SUBTRACT) Subtract();
        if (equationType == EquationType.MULTIPLY) Multiply();
        if (equationType == EquationType.DIVIDE) Divide();
    }


    public enum EquationType
    {
        None = 0,
        ADD = 1,
        SUBTRACT = 2,
        MULTIPLY = 3,
        DIVIDE = 4
    }
}
