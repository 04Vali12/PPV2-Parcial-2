using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Option : MonoBehaviour
{
    public int OptionID;
    public string OptionName;

    // Start is called before the first frame update
    void Start()
    {
        transform.GetChild(0).GetComponent<TMP_Text>.text = OptionName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
