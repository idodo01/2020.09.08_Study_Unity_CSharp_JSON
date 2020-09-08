using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using LitJson;
using System; // Convert.ToInt32

public class CountSaveTest : MonoBehaviour
{
    private string CountString; //파일의 모든 텍스트를 string 형태로 저장하기 위해
    private JsonData CountData; //string 형태의 데이터를 Json 형태로 변경하기 위해
    private string[] Cstring = new string[2];
    private JsonData Cdata;

    //private int UpCount = 0;

    void Start()
    {
        CountString = File.ReadAllText(Application.dataPath + "/DB/Count.json");
        CountData = JsonMapper.ToObject(CountString);
        
    }

    public void ClickSave()
    {
        //UpCount = CountData["Count"]+1;
        //UpCount = Convert.ToInt32(CountData["Count"].ToString())+1;
        //Cstring[0] = UpCount.ToString();
        Cstring[0] = CountData["Count"].ToString();

        Cdata = JsonMapper.ToJson(Cstring);
        File.WriteAllText(Application.dataPath + "/DB/Count.json", Cdata.ToString());
    }
}