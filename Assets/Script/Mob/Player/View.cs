using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class View : MonoBehaviour {

	public Rect position;
	public Text sample;
	public Text text;
	public Text inputField;
	public InputField field;
	public string url = "hidden-sands-4551.herokuapp.com/db";
	public WWW www;
	public Transform parent;




	IEnumerator Start () {

		www = new WWW(url);
		yield return www;
		position = new Rect(0,0,Screen.width,Screen.height);
		Print(www.text);

	}


	public void Print(string str){
		Text text = Instantiate (sample) as Text;
		text.text = "> " + str;
		text.transform.SetParent(parent);
		field.IsActive();

	}



}

