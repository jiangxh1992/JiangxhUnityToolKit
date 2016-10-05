using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using LitJson;

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

	public FamilyList m_FamilyList = null;
	public TextAsset JsonTxt;

	// Use this for initialization
	void Start () {
		string josnStr = JsonTxt.text;
		m_FamilyList = JsonMapper.ToObject<FamilyList> (josnStr);
		foreach (FamilyInfo info in m_FamilyList.family_list) {  
			Debug.Log("Name:" + info.name + "       Age:" + info.age + "        Tel:" + info.tellphone + "      Addr:" + info.address);  
		} 
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
