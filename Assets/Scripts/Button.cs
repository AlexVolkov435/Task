using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    private bool _isStop = false;

    [SerializeField] private Animator _animator;
    [SerializeField] GameObject _effect;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _effect.gameObject.SetActive(false);
    }

    public void Go()
    {
        _isStop = true;
        _animator.SetBool("isStop", _isStop);
        _effect.gameObject.SetActive(true);
    }
}
