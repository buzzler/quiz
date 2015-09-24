using UnityEngine;
using System.Collections;

public class OptionScreen : MonoBehaviour,IFageUIPopupComponent {
	public	void OnUIInstantiate(FageUIPopupMem mem, params object[] param) {}
	public	void OnUIInstantiated(FageUIPopupMem mem) {}
	public	void OnUIDestroy(FageUIPopupMem mem) {}
	public	void OnSwitchOut(FageUIPopupMem mem) {}
	public	void OnSwitchIn(FageUIPopupMem mem) {}

	public	GameObject	GetGameObject() {
		return gameObject;
	}

	public	void OnClickClose() {
		FageUIManager.Instance.Popdown();
	}
}
