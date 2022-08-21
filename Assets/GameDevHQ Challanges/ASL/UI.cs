using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    private Text _mainText;
    private string _sometext;
    
    // Start is called before the first frame update
    void Start()
    {
        //_mainText.GetComponent<Text>().text = "Welcome to the game";
        _mainText = _mainText.GetComponentInChildren<Text>();
        // = "Welcome to the game";

        _sometext = "abcdefghijklmnopqrstuvwxyz";

        foreach(char letter in _sometext)
        {
            _mainText.text += letter;
        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
