using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GeradorDeCor : MonoBehaviour {

	public Slider _r;
	public Slider _g;
	public Slider _b;

	public Image _viewCor;

	public Text _textCor;

	public GameObject _cubo;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		_cubo.GetComponent<Renderer> ().material.color = _viewCor.color;
	}

	public void TrocarCor()
	{
		_viewCor.color = new Color (_r.value,_g.value,_b.value);
		_textCor.text = _viewCor.color.ToString ();
	}

	public void GerarCor()
	{
		float tempR = Random.Range (0.0f,1.0f);
		float tempG = Random.Range (0.0f,1.0f);
		float tempB = Random.Range (0.0f,1.0f);
		_viewCor.color = new Color (tempR,tempG,tempB);
		_r.value = tempR;
		_g.value = tempG;
		_b.value = tempB;
		_textCor.text = _viewCor.color.ToString ();
	}
}
