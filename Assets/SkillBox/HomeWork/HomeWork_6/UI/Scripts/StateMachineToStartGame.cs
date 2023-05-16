using UnityEngine;

public class StateMachineToStartGame : MonoBehaviour
{
    [SerializeField] private Screen[] _allStartScreen;

    public int screen = 1;

    public void Change()
    {
        for (int i = 0;  i < _allStartScreen.Length; i++)
        {
            if (i == screen)
            {
                _allStartScreen[screen].gameObject.SetActive(true);
                continue;
            }
            _allStartScreen[i].gameObject.SetActive(false);
                
        }
        screen++;   
    }
}
