using UnityEngine;         //引用 Unity 命名空間 (API)

// 命名空間 空間名稱
// 多人開發可以使用命名空間區隔系統避免衝突
namespace lepo
{
    // 公開 類別 腳本名稱 (與左上角綁案名稱相同 大小寫一樣 不能使用空格與特殊字元
    public class topdown : MonoBehaviour
    {
        #region 資料:保存系統需要的基本資料 例如:移動速度 動畫參數名稱與元件等等
        // 欄位 field 語法:修飾詞 資料名稱(指定 初始值);
        private float speed = 10.5f;
        private string parameterRun = "開關跑步";
        private string parameterDead = "開關死亡";
        private Animator ani;
        private Rigidbody2D rig;
        #endregion

        #region 事件:程式入口(unity) 提供開發者驅動系統的窗口
        // 喚醒事件:撥放遊戲後執行一次 處理初始化 取得資料 資料初始化
        private void Awake()
        {
            //輸出(訊息)將訊息輸出到unity console(儀表板)ctrl + shift + c
            print("我是喚醒事件~");

            //欄位 指定為 取得元件<元件名稱>()
            // <泛型> 泛型:指任何形式
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
        }

        //更新事件:播放遊戲後以每秒約60次執行 60FPS(frame per second)
        //處理:持續性行為 移動 旋轉 縮放 玩家輸入 滑鼠 鍵盤 觸控 搖桿
        private void Update()
        {
            print("我在 Update 事件內");
        }
        #endregion

        #region 方法:較複雜的功能(陳述式 演算法或程式區塊)
        #endregion
    }
}
