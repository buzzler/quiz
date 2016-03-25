using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SubjectScreen : MonoBehaviour, IFageUIComponent {
	public	ToggleGroup	tg;
	public	Button		buttonStart;
	private	bool		reserved;

	public	void OnUIInstantiate(FageUIMem mem, params object[] param) {}
	public	void OnUIInstantiated(FageUIMem mem) {}
	public	void OnUIDestroy(FageUIMem mem) {}
	public	void OnSwitchOut(FageUIMem mem) {}
	public	void OnSwitchIn(FageUIMem mem) {}
	public	void OnUIPause(FageUIMem mem) {}
	public	void OnUIResume(FageUIMem mem, params object[] param) {}
	public	void OnUIResumed(FageUIMem mem) {}
	
	public	GameObject	GetGameObject() {
		return gameObject;
	}

	public	void OnClickStart() {
		FageUIManager.Instance.Change(FageUIRoot.Instance.FindUISet("ui_single"));
	}

	public	void OnClickBack() {
		FageUIManager.Instance.Change(FageUIRoot.Instance.FindUISet("ui_title"));
	}

	void Start() {
		buttonStart.interactable = false;
	}

	void Update() {
		if (tg.AnyTogglesOn() && (!reserved)) {
			reserved = true;
			buttonStart.interactable = true;
		}
	}
}
