using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface iSubject
{	void RegisterObserver(iTurret observer);
	void RemoveObserver(iTurret observer);
	void NotifyObservers();
}
