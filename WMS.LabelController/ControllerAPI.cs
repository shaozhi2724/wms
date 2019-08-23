using System;
using   System.Runtime.InteropServices;

public class ControllerAPI
{
    //////////////////////////////////////////////////////////////////////////
    /// <summary>
    /// 系统API 调用初始化函数，必须第一个被调用，只调用一次即可
    /// </summary>
    /// <returns></returns>
    [DllImport("LanCmdSender.dll")]
    public static extern IntPtr InitializeTrans();
    /// <summary>
    /// 系统退出API 调用
    /// </summary>
    [DllImport("LanCmdSender.dll")]
    public static extern void ExitTrans();
    /// <summary>
    /// 网络控制器标签货号对应关系配置
    /// </summary>
    /// <param name="hWnd"></param>
    /// <returns></returns>
    [DllImport("LanCmdSender.dll", EntryPoint = "SetupConfig", CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr SetupConfig(IntPtr hWnd);

    /// <summary>
    /// 网络连接到控制器，以便发送指令， 其中第一个参数为控制器IP 地址，
    /// 第二个参数为网络端口，固定值8600
    /// </summary>
    /// <param name="lpszAddr">控制器IP地址</param>
    /// <param name="uPort">网络端口，固定值8600</param>
    /// <returns></returns>
    [DllImport("LanCmdSender.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool ConnectController( [In] [MarshalAsAttribute(UnmanagedType.LPStr)] string lpszAddr, uint uPort);

    [DllImport("LanCmdSender.dll")]
    public static extern void DisConnect();

    [DllImport("LanCmdSender.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool IsConnected();
    /// <summary>
    /// 设置接受网络控制器回应数据的消息接收窗口，
    /// 设置窗口后，用于接收消息的窗口应建立消息映射函数，以便数据处理。
    /// </summary>
    /// <param name="hWnd"></param>
    /// <returns></returns>
    [DllImport("LanCmdSender.dll", EntryPoint = "SetMessageHandler")]
    public static extern IntPtr SetMessageHandler(IntPtr hWnd);

    [DllImport("LanCmdSender.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool RecvOK();

    [DllImport("LanCmdSender.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool GetData();

    /*只支持汉字标签
        //////////////////////////////////////////////////////////////////////////
        // commands list
        //
        //////////////////////////////////////////////////////////////////////////
        #region 只支持汉字标签

        /// <summary>
        /// 群发显示命令“L” (0X4C)，对应API：BeginTransLcmd,
        /// 汉字标签群发显示命令（只支持汉字标签）
        /// </summary>
        /// <returns></returns>
        [DllImport("LanCmdSender.dll")]
        public static extern int BeginTransLcmd(); //汉字标签群发显示命令

        /// <summary>
        /// 群发显示命令“L” (0X4C)，对应API：AddTransLcmd，
        /// 汉字标签群发显示命令（只支持汉字标签）
        /// </summary>
        /// <param name="lpszCargo"></param>
        /// <param name="iCol1"></param>
        /// <param name="lpszLine1"></param>
        /// <param name="iCol2"></param>
        /// <param name="lpszLine2"></param>
        /// <param name="iCol3"></param>
        /// <param name="lpszLine3"></param>
        /// <param name="iCol4"></param>
        /// <param name="lpszLine4"></param>
        /// <param name="chLight"></param>
        /// <returns></returns>
        [DllImport("LanCmdSender.dll")]
        public static extern int AddTransLcmd(string lpszCargo, int iCol1, string lpszLine1, int iCol2, string lpszLine2,
            int iCol3, string lpszLine3, int iCol4, string lpszLine4, char chLight);
        /// <summary>
        /// 群发显示命令“L” (0X4C)，对应API：EndTransLcmd，
        /// 汉字标签群发显示命令（只支持汉字标签）
        /// </summary>
        /// <returns></returns>
        [DllImport("LanCmdSender.dll")]
        public static extern int EndTransLcmd();

        [DllImport("LanCmdSender.dll")]
        public static extern int BeginTrans5Bcmd(); //[ 清屏群发

        [DllImport("LanCmdSender.dll")]
        public static extern int AddTrans5Bcmd(string lpszCargo);

        [DllImport("LanCmdSender.dll")]
        public static extern int EndTrans5Bcmd();

        [DllImport("LanCmdSender.dll")]
        public static extern int BeginTrans5Dcmd(); //] 滚动群发

        [DllImport("LanCmdSender.dll")]
        public static extern int AddTrans5Dcmd(string lpszCargo, int iLine, int bCmdScroll);

        [DllImport("LanCmdSender.dll")]
        public static extern int EndTrans5Dcmd();

        /// <summary>
        /// 改变显示方式命令“E” (0X45)，对应API：TransEcmd，
        /// 改变显示方式（显示方式：正常，反白）（只支持汉字标签）
        /// </summary>
        /// <param name="lpszCargo"></param>
        /// <param name="iLine"></param>
        /// <param name="bShowMode"></param>
        /// <returns></returns>
        [DllImport("LanCmdSender.dll")]
        public static extern int TransEcmd(string lpszCargo, int iLine, int bShowMode);

        /// <summary>
        /// 清显示屏指定行命令“F” (0X46)，对应API：TransFcmd，
        /// 清显示屏指定行命令（只支持汉字标签）
        /// </summary>
        /// <param name="lpszCargo"></param>
        /// <param name="uCmd"></param>
        /// <returns></returns>
        [DllImport("LanCmdSender.dll")]
        public static extern int TransFcmd(string lpszCargo, int uCmd);

        [DllImport("LanCmdSender.dll")]
        public static extern int Trans7Bcmd();

        [DllImport("LanCmdSender.dll")]
        public static extern int TransRcmd(string lpszCargo, int iMode);

        /// <summary>
        /// 货号修改命令“P”，对应API：TransZcmd，修改电子标签机货号（适用于数字和汉字标签）
        /// </summary>
        /// <param name="lpszCargo"></param>
        /// <param name="iCol1"></param>
        /// <param name="lpszLine1"></param>
        /// <param name="iCol2"></param>
        /// <param name="lpszLine2"></param>
        /// <param name="iCol3"></param>
        /// <param name="lpszLine3"></param>
        /// <param name="iCol4"></param>
        /// <param name="lpszLine4"></param>
        /// <param name="chLight"></param>
        /// <returns></returns>
        [DllImport("LanCmdSender.dll")]
        public static extern int TransZcmd(string lpszCargo, int iCol1, string lpszLine1, int iCol2, string lpszLine2,
            int iCol3, string lpszLine3, int iCol4, string lpszLine4, char chLight); //中文字符标签数据显示指令
        /// <summary>
        /// 中文数据下传命令“Z”，对应API：TransZcmd
        /// </summary>
        /// <returns></returns>
        [DllImport("LanCmdSender.dll")]
        public static extern int TransZcmds();

        [DllImport("LanCmdSender.dll")]
        public static extern int Transucmd(string lpszCargo);

        [DllImport("LanCmdSender.dll")]
        public static extern int TransCcmd(string lpszCargo, int bLightOn);

        /// <summary>
        /// 滚动显示指定行命令“V” (0X56)，对应API：TransVcmd，
        /// 滚动显示指定行文本信息（只支持汉字标签）
        /// </summary>
        /// <param name="lpszCargo"></param>
        /// <param name="uLine"></param>
        /// <param name="bScrool"></param>
        /// <returns></returns>
        [DllImport("LanCmdSender.dll")]
        public static extern int TransVcmd(string lpszCargo, int uLine, int bScrool);

        /// <summary>
        /// 点亮标签背光灯命令“W” (0X57)，对应API：TransWcmd，
        /// 开关标签背光灯（只支持汉字标签）
        /// </summary>
        /// <param name="lpszCargo"></param>
        /// <param name="bLightOn"></param>
        /// <returns></returns>
        [DllImport("LanCmdSender.dll")]
        public static extern int TransWcmd(string lpszCargo, int bLightOn);

        #endregion
    */

    /// <summary>
    /// 通用数据下传命令“T”(0X51), 对应API：TransTcmd，
    /// 下传数据到电子标签（只支持数字标签）
    /// </summary>
    /// <param name="lpszCargo">表示标签编号</param>
    /// <param name="lpData"></param>
    /// <param name="chLight">表示指示灯的显示，取值如下：J(4AH) - 表示红灯亮; K(4BH) - 表示蓝灯亮; L(4CH) - 表示绿灯亮; G(47H) - 表示指示灯灭</param>
    /// <param name="chLightCmd">指示灯控制参数,取值0/1,表示关/开,为0时忽略chLight参数</param>
    /// <param name="chBeep">蜂鸣器开关参数,取值0/1,或者”0”/”1”,表示“关/开”</param>
    /// <returns></returns>
    [DllImport("LanCmdSender.dll")]
    //public static extern int TransTcmd(string lpszCargo, string lpData, char chLight, char chLightCmd, char chBeep);

    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool TransTcmd([In] [MarshalAs(UnmanagedType.LPStr)] string lpszCargo, [In] [MarshalAs(UnmanagedType.LPStr)] string lpData, byte chLight, byte chLightCmd, byte chBeep);
    //通用数据下传命令“T”
    /// <summary>
    /// 群发数据下传命令“A” ,对应API：BeginTransTcmds，下传数据到多个电子标签（只支持数字标签）
    /// </summary>
    /// <returns></returns>
    [DllImport("LanCmdSender.dll")]
    public static extern int BeginTransTcmds(); //数字群发指令

    /// <summary>
    /// 群发数据下传命令“A” ,对应API：AddTransTcmd，下传数据到多个电子标签（只支持数字标签）
    /// </summary>
    /// <param name="lpszCargo"></param>
    /// <param name="lpData"></param>
    /// <param name="chLight"></param>
    /// <param name="chBeep"></param>
    /// <returns></returns>
    [DllImport("LanCmdSender.dll")]
    public static extern int AddTransTcmd(string lpszCargo, string lpData, char chLight, char chBeep);

    /// <summary>
    /// 群发数据下传命令“A” ,对应API：EndTransTcmds，下传数据到多个电子标签（只支持数字标签）
    /// </summary>
    /// <returns></returns>
    [DllImport("LanCmdSender.dll")]
    public static extern int EndTransTcmds();
    /// <summary>
    /// 蜂鸣器发声控制命令“K” (0X4B)，对应API：TransKcmd，
    /// 控制电子标签蜂鸣器发声（支持汉字标签和数字标签）
    /// </summary>
    /// <param name="lpszCargo"></param>
    /// <returns></returns>
    [DllImport("LanCmdSender.dll")]
    public static extern int TransKcmd(string lpszCargo); //发声控制命令“K”

    /// <summary>
    /// 关闭控制器电源指令“U”，对应API：TransUcmd，用于停机关闭使用
    /// </summary>
    /// <returns></returns>
    [DllImport("LanCmdSender.dll")]
    public static extern int TransUcmd(); //shutdown power

    /// <summary>
    /// 显示所有机器号命令“&” (0X26)，对应API：TransIDcmd，
    /// 电子标签显示各自机器号（支持汉字标签和数字标签）
    /// </summary>
    /// <returns></returns>
    [DllImport("LanCmdSender.dll")]
    public static extern int TransIDcmd(); //show id

    /// <summary>
    /// 货号修改命令“P”, 根据货号修改, 对应API：TransPcmd
    /// </summary>
    /// <param name="lpszCargo"></param>
    /// <param name="lpszCargoNew"></param>
    /// <returns></returns>
    [DllImport("LanCmdSender.dll")]
    public static extern int TransPcmd(string lpszCargo, string lpszCargoNew); //change label ID

    /// <summary>
    /// 货号修改命令“P”, 根据COM 口和标签ID 修改货号, 对应API：TransPcmd2
    /// </summary>
    /// <param name="uLblID"></param>
    /// <param name="uPort"></param>
    /// <param name="lpszCargoNew"></param>
    /// <returns></returns>
    [DllImport("LanCmdSender.dll")]
    public static extern int TransPcmd2(int uPort, int uLblID, string lpszCargoNew);

    /// <summary>
    /// 货号修改命令“P”, 修改物理标签ID, 对应API：TransPcmd3
    /// </summary>
    /// <param name="uPort"></param>
    /// <param name="uLblID"></param>
    /// <param name="uLblNewID"></param>
    /// <returns></returns>
    [DllImport("LanCmdSender.dll")]
    public static extern int TransPcmd3(int uPort, int uLblID, int uLblNewID);

    /// <summary>
    /// 标签查询命令”Q” (0X51)，反馈电子标签状态, 对应API：TransQcmd，（适用于数字标签）
    /// </summary>
    /// <param name="lpszCargo"></param>
    /// <returns></returns>
    [DllImport("LanCmdSender.dll")]
    public static extern int TransQcmd(string lpszCargo); //通用状态查询命令"Q" (0X51), 反馈电子标签状态（只支持数字标签）

    /// <summary>
    /// 标签配置命令“b” ，对应API：Transbcmd，
    /// </summary>
    /// <param name="lpszCargo"></param>
    /// <param name="lpszConfig"></param>
    /// <returns></returns>
    [DllImport("LanCmdSender.dll")]
    public static extern int Transbcmd(string lpszCargo, string lpszConfig); //config label

    /// <summary>
    /// 清屏命令(0X0C)，对应API：Trans0Ccmd
    /// </summary>
    /// <param name="lpszCargo"></param>
    /// <returns></returns>
    [DllImport("LanCmdSender.dll")]
    //public static extern int Trans0Ccmd(string lpszCargo);

    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool Trans0Ccmd([In, MarshalAs(UnmanagedType.LPStr)] string lpszCargo);
    /// <summary>
    /// 机器号识别命令（”I”），对应API：Trans49cmd
    /// </summary>
    /// <param name="lpszCargo"></param>
    /// <returns></returns>
    [DllImport("LanCmdSender.dll")]
    public static extern int Trans49cmd(string lpszCargo); //|

    [DllImport("LanCmdSender.dll")]
    public static extern int TransAddCmd(int uPort, int uID, string lpszCargo); //增加删除标签指令

    [DllImport("LanCmdSender.dll")]
    public static extern int TransDelCmd0(string lpszCargo);

    [DllImport("LanCmdSender.dll")]
    public static extern int TransDelCmd1(int uPort);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="uMode"></param>
    /// <param name="lpData"></param>
    /// <returns></returns>
    [DllImport("LanCmdSender.dll")]
    public static extern int TransQueryConfigCmd(int uMode, string lpData);

    //////////////////////////////////////////////////////////////////////////
    //const var
    /// <summary>
    /// 控制器向客户端发送数据时，客户端收到控制器发送过来的消息
    /// </summary>
    public const int DATA_RECV = 0x0400 + 19;
    /// <summary>
    /// 客户端连接到控制器后，控制器向客户端发送的消息
    /// </summary>
    public const int PC_CONN = 0x0400 + 20;
}
