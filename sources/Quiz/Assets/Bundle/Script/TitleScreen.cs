using UnityEngine;
using System.Collections;

public class TitleScreen : MonoBehaviour, IFageUIComponent {
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

	public	void OnClickSingle() {
		FageUIManager.Instance.Push(FageUIRoot.Instance.FindUISet("ui_subject"));
	}

	public	void OnClickVS() {
		FageUIManager.Instance.Push(FageUIRoot.Instance.FindUISet("ui_vssubject"));
	}

	public	void OnClickUpgrade() {
		FageUIManager.Instance.Popup(FageUIRoot.Instance.FindUISet("ui_upgrade"));
	}

	public	void OnClickStore() {
		FageUIManager.Instance.Popup(FageUIRoot.Instance.FindUISet("ui_store"));
	}

	public	void OnClickThunder() {
		FageUIManager.Instance.Popup(FageUIRoot.Instance.FindUISet("ui_thunder"));
	}

	public	void OnClickOption() {
		FageUIManager.Instance.Popup(FageUIRoot.Instance.FindUISet("ui_option"));
	}
}
