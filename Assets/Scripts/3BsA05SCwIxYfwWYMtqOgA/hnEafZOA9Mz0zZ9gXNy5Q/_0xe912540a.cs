using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;
using TouchPhase = UnityEngine.InputSystem.TouchPhase;

public class _0xe912540a : MonoBehaviour
{
    private Touch? _0x2b1bbb1c()
    {
        if (!_0xd7c56e10.Instance._0x24ed0ec1)
            return null;
        foreach (Touch _0x317afba1 in Touch.activeTouches)
            if (!_0x317afba1.ended)
                if (this._0x4eeb97b0(_0x317afba1))
                    return _0x317afba1;
        return null;
    }

    private void Awake()
    {
        EnhancedTouchSupport.Enable();
        _0x72218aa0 = this.gameObject.GetComponent<_0xe912540a>();
    }

    private Touch? _0xbd71dc9c(Bounds _0xa6b13de0)
    {
        if (!_0xd7c56e10.Instance._0x24ed0ec1)
            return null;
        foreach (Touch _0x5b51d76e in Touch.activeTouches)
            if (_0x5b51d76e.ended)
            {
                Vector3 _0x72e82cdd = Camera.main.ScreenToWorldPoint(_0x5b51d76e.screenPosition);
                Vector3 _0xca3f6e2c = new(_0x72e82cdd.x, _0x72e82cdd.y, _0xa6b13de0.center.z);
                if (_0xa6b13de0.Contains(_0xca3f6e2c) && this._0x4eeb97b0(_0x5b51d76e))
                    return _0x5b51d76e;
            }

        return null;
    }

    private Touch? _0xb6f9c384()
    {
        if (!_0xd7c56e10.Instance._0x24ed0ec1)
            return null;
        foreach (Touch _0x001615cd in Touch.activeTouches)
            if (_0x001615cd.ended)
                if (this._0x4eeb97b0(_0x001615cd))
                    return _0x001615cd;
        return null;
    }

    private static _0xe912540a _0x72218aa0;
    public BoxCollider2D CameraTouchBounds;
    private Touch? _0x3df344d1(Bounds _0xd292cefd)
    {
        if (!_0xd7c56e10.Instance._0x24ed0ec1)
            return null;
        foreach (Touch _0x14369a47 in Touch.activeTouches)
            if (!_0x14369a47.ended)
            {
                Vector3 _0x26d24731 = Camera.main.ScreenToWorldPoint(_0x14369a47.screenPosition);
                Vector3 _0x227a1e2c = new(_0x26d24731.x, _0x26d24731.y, _0xd292cefd.center.z);
                if (_0xd292cefd.Contains(_0x227a1e2c) && this._0x4eeb97b0(_0x14369a47))
                    return _0x14369a47;
            }

        return null;
    }

    private void _0xfd09c572(Touch? _0x8eb5633f)
    {
        if (!_0xd7c56e10.Instance._0x24ed0ec1)
        {
            _0x8eb5633f = null;
            return;
        }

        int _0x24aed9ba = _0x8eb5633f.Value.touchId;
        _0x8eb5633f = Touch.activeTouches.FirstOrDefault(_0x7dea8110 => _0x7dea8110.touchId == _0x24aed9ba);
        if (!this._0x4eeb97b0(_0x8eb5633f.Value))
            _0x8eb5633f = null;
    }

    private bool _0x4eeb97b0(Touch? _0x39fe29aa)
    {
        if (!_0x39fe29aa.HasValue)
            return false;
        Vector3 _0x526d1310 = Camera.main.ScreenToWorldPoint(_0x39fe29aa.Value.screenPosition);
        Vector3 _0xcfc71630 = _0x526d1310;
        _0xcfc71630.z = this.CameraTouchBounds.transform.position.z;
        if (this.CameraTouchBounds.bounds.Contains(_0xcfc71630))
            return true;
        _0x39fe29aa = null;
        return false;
    }

    private Touch? _0x395dfd97(Bounds _0xa09aa5dc, TouchPhase _0x9909f088)
    {
        if (!_0xd7c56e10.Instance._0x24ed0ec1)
            return null;
        foreach (Touch _0xc7554457 in Touch.activeTouches)
            if (_0xc7554457.phase == _0x9909f088)
            {
                Vector3 _0xf210f5c7 = Camera.main.ScreenToWorldPoint(_0xc7554457.screenPosition);
                Vector3 _0x61854744 = new(_0xf210f5c7.x, _0xf210f5c7.y, _0xa09aa5dc.center.z);
                if (_0xa09aa5dc.Contains(_0x61854744) && this._0x4eeb97b0(_0xc7554457))
                    return _0xc7554457;
            }

        return null;
    }

    private bool _0xd54ac5c9(Touch? _0x4f8b46e2, Bounds _0x42b7f670, TouchPhase _0x81930f6e)
    {
        if (!_0xd7c56e10.Instance._0x24ed0ec1)
        {
            _0x4f8b46e2 = null;
            return false;
        }

        if (_0x4f8b46e2 != null)
            if (_0x4f8b46e2.Value.phase == _0x81930f6e)
            {
                Vector3 _0xb01d0446 = Camera.main.ScreenToWorldPoint(_0x4f8b46e2.Value.screenPosition);
                Vector3 _0x4f7f9276 = new(_0xb01d0446.x, _0xb01d0446.y, _0x42b7f670.center.z);
                if (_0x42b7f670.Contains(_0x4f7f9276) && this._0x4eeb97b0(_0x4f8b46e2.Value))
                    return true;
            }

        return false;
    }
}