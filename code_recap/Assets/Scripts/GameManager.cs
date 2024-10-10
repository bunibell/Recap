using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Variables 
    public TextMeshProUGUI saveText;
    private string inputText = "Hi";
    public string sTxt;

    //Create the filepath to the TXT document we are saving in
    private const string DIR_RES = "/Resources";
    private const string FILE_INFOSAVE = DIR_RES + "/InfoSave.txt";
    private string FILE_PATH_INFO;


    // Start is called before the first frame update
    void Start()
    {
        //Declare the file path 
        FILE_PATH_INFO = Application.dataPath + FILE_INFOSAVE;

        saveText.text = inputText;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.W)) 
        {
            SaveText("I added a Line");
        }
        if (Input.GetKeyUp(KeyCode.Q))
        {
            LoadText();        
        }
    }

    public void SaveText(string text)
    {
        sTxt = text;
        string fileContents = File.ReadAllText(FILE_PATH_INFO);
        fileContents += sTxt + "\n";
        File.WriteAllText(FILE_PATH_INFO, fileContents);
    }

    public void LoadText()
    {
        string fileContents = File.ReadAllText(FILE_PATH_INFO);
        saveText.text = fileContents;
    }
}
