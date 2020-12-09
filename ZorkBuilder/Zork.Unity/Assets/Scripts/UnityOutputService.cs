using System.Collections.Generic;
using UnityEngine;
using Zork;
using TMPro;

public class UnityOutputService : MonoBehaviour, IOutputService
{
    [SerializeField]
    private TextMeshProUGUI TextLinePrefab;

    [SerializeField]
    private Transform OutputTextContainer;

    [SerializeField]
    private int MaxTextLines = 60;

    public UnityOutputService()
    {
        mTextLines = new List<GameObject>();
    }

    public void Clear()
    {
        throw new System.NotImplementedException();
    }

    public void Write(string value)
    {
        throw new System.NotImplementedException();
    }

    public void Write(object value)
    {
        Write(value.ToString());
    }

    public void WriteLine(string value)
    {
        //OutputText.text = value;
        if(mTextLines.Count >= MaxTextLines)
        {
            Destroy(mTextLines[0]);
            mTextLines.RemoveAt(0);
        }

        var textLine = Instantiate(TextLinePrefab);
        textLine.transform.SetParent(OutputTextContainer, false);
        textLine.text = value;
        mTextLines.Add(textLine.gameObject);
    }

    public void WriteLine(object value)
    {
        WriteLine(value.ToString());
    }

    private List<GameObject> mTextLines;
}
