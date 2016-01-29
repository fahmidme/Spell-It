using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Menu : MonoBehaviour {

	public Button playBtn;
	public AudioSource buttonIn;
	public AudioSource buttonOut;

	private Vector2 playBtnInitDimen;

	// Use this for initialization
	void Start () {
		playBtnInitDimen = playBtn.image.rectTransform.sizeDelta;
	}

	void Update () {

	}

	public void touchIn() {
		playBtn.image.rectTransform.sizeDelta = new Vector2 (playBtnInitDimen.x + 20, playBtnInitDimen.y + 20);
		buttonOut.Stop ();
		buttonIn.Play ();
	}

	public void touchOut() {
		playBtn.image.rectTransform.sizeDelta = new Vector2 (playBtnInitDimen.x - 20, playBtnInitDimen.y - 20);
		buttonIn.Stop ();
		buttonOut.Play ();
	}

	void fadeIn() {

	}
}
