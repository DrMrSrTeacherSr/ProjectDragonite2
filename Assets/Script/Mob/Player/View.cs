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


		WWWForm form = new WWWForm();
		form.AddField("title","The one");
		form.AddField("subtitle","OMG");
		www = new WWW("hidden-sands-4551.herokuapp.com/register",form);
		yield return www;
		Print (www.text);

	}


	public void Print(string str){
		Text text = Instantiate (sample) as Text;
		if(str.StartsWith("/")){
			Print ("Handling Post Request:");
			Command(str);
			Print ("Post Handled:");
		}else{
			text.text = "> " + str;
			text.transform.SetParent(parent);
			text = Instantiate (sample) as Text;
			text.transform.SetParent(parent);
			field.IsActive();
			inputField.text = "";
		}

	}

	public IEnumerator Command(string str){
		WWWForm form = new WWWForm();
		form.AddField("title","The one");
		form.AddField("subtitle","OMG");
		www = new WWW("hidden-sands-4551.herokuapp.com/register",form);
		yield return www;
		Print (www.error);
	}

}

