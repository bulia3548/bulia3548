using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class _0x495ba6ba : MonoBehaviour
{
    private _0x48116e8c _0x72b30d36 = _0x48116e8c.Portrait;
    private float _0xe699a21b = 1;
    private new Camera _0xd06ce4cc;
    private void _0x6f23e3f4()
    {
        float _0x34438bd4, _0x50fa81c1, _0xa9db7565, _0x833513cc;
        if (this._0x72b30d36 == _0x48116e8c.Landscape)
            this._0xd06ce4cc.orthographicSize = 1f / this._0xd06ce4cc.aspect * this._0xe699a21b / 2f;
        else
            this._0xd06ce4cc.orthographicSize = this._0xe699a21b / 2f;
        this._0x17a5ff54 = 2f * this._0xd06ce4cc.orthographicSize;
        this._0x5a38082b = this._0x17a5ff54 * this._0xd06ce4cc.aspect;
        float _0x4dac2d4b = this._0xd06ce4cc.transform.position.x;
        float _0x0519c6df = this._0xd06ce4cc.transform.position.y;
        _0x34438bd4 = _0x4dac2d4b - this._0x5a38082b / 2;
        _0x50fa81c1 = _0x4dac2d4b + this._0x5a38082b / 2;
        _0xa9db7565 = _0x0519c6df + this._0x17a5ff54 / 2;
        _0x833513cc = _0x0519c6df - this._0x17a5ff54 / 2;
        this._0x22e99ea7 = new Vector3(_0x34438bd4, _0x833513cc, 0);
        this._0xd873cbfc = new Vector3(_0x4dac2d4b, _0x833513cc, 0);
        this._0x73949f8d = new Vector3(_0x50fa81c1, _0x833513cc, 0);
        this._0xa8cb2a1d = new Vector3(_0x34438bd4, _0x0519c6df, 0);
        this._0xbfa70a62 = new Vector3(_0x4dac2d4b, _0x0519c6df, 0);
        this._0x9641b99f = new Vector3(_0x50fa81c1, _0x0519c6df, 0);
        this._0x17750b5c = new Vector3(_0x34438bd4, _0xa9db7565, 0);
        this._0x388ba8fe = new Vector3(_0x4dac2d4b, _0xa9db7565, 0);
        this._0x0326b257 = new Vector3(_0x50fa81c1, _0xa9db7565, 0);
    }

    private Vector3 _0x0326b257 { get; set; }
    private float _0x17a5ff54 { get; set; }
    private Vector3 _0xbfa70a62 { get; set; }

    public enum _0x48116e8c
    {
        Landscape,
        Portrait
    }

    private Vector3 _0x388ba8fe { get; set; }
    private Vector3 _0xa8cb2a1d { get; set; }
    //public bool executeInUpdate;
    private float _0x5a38082b { get; set; }

    private static _0x495ba6ba _0x20b27b9e;
    private Vector3 _0x73949f8d { get; set; }
    private Vector3 _0xd873cbfc { get; set; }

    private void OnDrawGizmos()
    {
        Gizmos.color = this._0xa34c9582;
        Matrix4x4 _0xe550a9ef = Gizmos.matrix;
        Gizmos.matrix = Matrix4x4.TRS(this.transform.position, this.transform.rotation, Vector3.one);
        if (this._0xd06ce4cc.orthographic)
        {
            float _0x6a847c82 = this._0xd06ce4cc.farClipPlane - this._0xd06ce4cc.nearClipPlane;
            float _0xe50c016c = (this._0xd06ce4cc.farClipPlane + this._0xd06ce4cc.nearClipPlane) * 0.5f;
            Gizmos.DrawWireCube(new Vector3(0, 0, _0xe50c016c), new Vector3(this._0xd06ce4cc.orthographicSize * 2 * this._0xd06ce4cc.aspect, this._0xd06ce4cc.orthographicSize * 2, _0x6a847c82));
        }
        else
        {
            Gizmos.DrawFrustum(Vector3.zero, this._0xd06ce4cc.fieldOfView, this._0xd06ce4cc.farClipPlane, this._0xd06ce4cc.nearClipPlane, this._0xd06ce4cc.aspect);
        }

        Gizmos.matrix = _0xe550a9ef;
    }

    private Vector3 _0x22e99ea7 { get; set; }
    private Vector3 _0x17750b5c { get; set; }
    private Vector3 _0x9641b99f { get; set; }

    private Color _0xa34c9582 = Color.white;
    private void Awake()
    {
        this._0xd06ce4cc = this.GetComponent<Camera>();
        _0x20b27b9e = this;
        this._0x6f23e3f4();
    }
}