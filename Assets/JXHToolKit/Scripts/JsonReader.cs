using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using LitJson;

// 家庭成员信息数据结构
public class FamilyInfo {  
	public string name;  
	public int age;  
	public string tellphone;  
	public string address;  
}  

public class FamilyList {  
	public List<FamilyInfo> family_list;  
} 

public class JsonReader : MonoBehaviour {

    // 家庭成员列表数据结构
	public FamilyList m_FamilyList = null;
    // json文件对象
	public TextAsset JsonTxt;

	void Start () {
        // 获取json字符串
		string josnStr = JsonTxt.text;
        // json字符串转对象
		m_FamilyList = JsonMapper.ToObject<FamilyList> (josnStr);
        // 打印对象
		foreach (FamilyInfo info in m_FamilyList.family_list) {  
			Debug.Log("Name:" + info.name + "       Age:" + info.age + "        Tel:" + info.tellphone + "      Addr:" + info.address);  
		} 
	}
	
	void Update () {
	
	}
}
