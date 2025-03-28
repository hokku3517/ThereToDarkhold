using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthVignette : MonoBehaviour
{
    private SpriteRenderer _SpriteRenderer;
    private Color _colorChannel;
    public float _rChannel, _gChannel, _bChannel, _aChannel;
    public int _timer, areaLoadTitleID, timerSwitch;
    // Start is called before the first frame update

    private GameObject title;

    void Start()
    {
        _SpriteRenderer = GetComponent<SpriteRenderer>();
        _SpriteRenderer.color = Color.blue;
       
        _rChannel = 1f;
        _gChannel = 1f;
        _bChannel = 1f;
        _aChannel = 0;    

        areaLoadTitleID = 0;
        timerSwitch = 0;

    }

    // Update is called once per frame
    void Update()
    {
        
        if (timerSwitch == 0){
            Alpha();
        } else if (timerSwitch == 1){
            Beta();
        }

        Debug.Log(_aChannel);
        _SpriteRenderer.color = new Color(1,1,1,_aChannel);
    }

    private void Alpha(){
        if (_timer != 60){
            _timer++;
        } else if (_timer == 60){
            _timer = 0;
            _aChannel = _aChannel + .1f;
        }
        if (_aChannel >= 1){
            timerSwitch++;
        }
    }
    private void Beta(){
        if (_timer != 60){
            _timer++;
        } else if (_timer == 60){
            _timer = 0;
            _aChannel = _aChannel - .1f;
        }
        if (_aChannel <= 0){
            timerSwitch++;
        }
    }


}
