using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.Pool; 

public class EnemyControl : MonoBehaviour
{
    public Transform _AlvoIni;
    public Transform _GrupoInimigos;

    public List<GameObject> _inimigo1_Lista = new List<GameObject>();
    public List<GameObject> _inimigos_Listas = new List<GameObject>();

    [SerializeField] float _TimeIni;
    float _Contador;
    bool _TimeAtivo = true;

    public List<Transform> _poslList = new List<Transform>();

    void Start()
    {
        
        _Contador = _TimeIni;
    }
    
    void Update()
    {
        if (_TimeAtivo)
        {
            _Contador -= Time.deltaTime;
            if (_Contador < 0)
            {
                //_TimeAtivo = false;
                _Contador = _TimeIni;
                Inimigo_On();
            }

        }
    }

    void Inimigo_On()
    {

        GameObject bullet = EnemyTipo1.SharedInstance.GetPooledObject();
        if (bullet != null)
        {
            int number = Random.Range(0, _poslList.Count);
            bullet.transform.position = _poslList[number].transform.position;
            //  bullet.transform.rotation = turret.transform.rotation;
            bullet.transform.SetParent(_GrupoInimigos.transform);
            bullet.GetComponent<MoveEnemy>()._Player = _AlvoIni;
            bullet.SetActive(true);
        }

    }


}
