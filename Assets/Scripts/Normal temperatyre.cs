using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalTemperature : MonoBehaviour
{
    private bool _isStop = false;

    [SerializeField] private Animator _animator;
    [SerializeField] GameObject _effect1;
    [SerializeField] GameObject _effect2;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _effect1.gameObject.SetActive(false);
        _effect2.gameObject.SetActive(false);
    }

    public void Reset()
    {
        _isStop = true;
        _animator.SetBool("isStop", _isStop);
        _effect1.gameObject.SetActive(false);
        _effect2.gameObject.SetActive(false);
    }
}