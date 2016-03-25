using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class VSSubjectScreen : MonoBehaviour,IFageUIComponent {
	public	ToggleGroup tg1;
	public	ToggleGroup tg2;
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

	public	void OnClickClose() {
		FageUIManager.Instance.Pop();
	}

	void Update() {
		if (tg1.AnyTogglesOn() && tg2.AnyTogglesOn() && (!reserved)) {
			FageUIManager.Instance.Change(FageUIRoot.Instance.FindUISet("ui_vs"));
			reserved = true;
		}
	}
}
