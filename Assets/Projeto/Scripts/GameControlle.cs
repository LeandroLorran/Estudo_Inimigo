using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class GameControlle : MonoBehaviour
{
    public Transform _player;
    [SerializeField] Transform _posInimigo;
    [SerializeField] Transform[] _IniPosV;
    [SerializeField] int _posNumb;


    void Start()
    {
        Invoke("InimigoOn", 1);
    }

    void InimigoOn()
    {
        GameObject bullet = InimigoPool.SharedInstance.GetPooledObject();
        if (bullet != null)
        {
            //bullet.transform.position = turret.transform.position;
            //bullet.transform.rotation = turret.transform.rotation;
            _posNumb = Random.Range(0, _IniPosV.Length);
            bullet.GetComponent<MoveEnemy2>().ResetInimigo(_IniPosV[_posNumb].position);
            bullet.SetActive(true);
        }


        Invoke("InimigoOn", 1);
    }


}
