using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Save : MonoBehaviour
{

// public Button saveButton;

    void CreateSave() {
        // save path
        string path = Application.dataPath + "/Save File.txt";

        // Initial text
        if (!File.Exists(path)) {
            File.WriteAllText(path,"Save \n");
        }
        
        // save content
        string content = "Current Time: " + System.DateTime.Now + "\n";

        // put content into txt file
        File.AppendAllText(path, content);
    }

    
    // Start is called before the first frame update
    void Start()
    {
        //Button btn = saveButton.GetComponent<Button>();
		//btn.onClick.AddListener(CreateSave);
        CreateSave();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
