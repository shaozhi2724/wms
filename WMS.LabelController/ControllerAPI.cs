using System;
using   System.Runtime.InteropServices;

public class ControllerAPI
{
    //////////////////////////////////////////////////////////////////////////
    /// <summary>
    /// ϵͳAPI ���ó�ʼ�������������һ�������ã�ֻ����һ�μ���
    /// </summary>
    /// <returns></returns>
    [DllImport("LanCmdSender.dll")]
    public static extern IntPtr InitializeTrans();
    /// <summary>
    /// ϵͳ�˳�API ����
    /// </summary>
    [DllImport("LanCmdSender.dll")]
    public static extern void ExitTrans();
    /// <summary>
    /// �����������ǩ���Ŷ�Ӧ��ϵ����
    /// </summary>
    /// <param name="hWnd"></param>
    /// <returns></returns>
    [DllImport("LanCmdSender.dll", EntryPoint = "SetupConfig", CallingConvention = CallingConvention.Cdecl)]
    public static extern IntPtr SetupConfig(IntPtr hWnd);

    /// <summary>
    /// �������ӵ����������Ա㷢��ָ� ���е�һ������Ϊ������IP ��ַ��
    /// �ڶ�������Ϊ����˿ڣ��̶�ֵ8600
    /// </summary>
    /// <param name="lpszAddr">������IP��ַ</param>
    /// <param name="uPort">����˿ڣ��̶�ֵ8600</param>
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
    /// ���ý��������������Ӧ���ݵ���Ϣ���մ��ڣ�
    /// ���ô��ں����ڽ�����Ϣ�Ĵ���Ӧ������Ϣӳ�亯�����Ա����ݴ���
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

    /*ֻ֧�ֺ��ֱ�ǩ
        //////////////////////////////////////////////////////////////////////////
        // commands list
        //
        //////////////////////////////////////////////////////////////////////////
        #region ֻ֧�ֺ��ֱ�ǩ

        /// <summary>
        /// Ⱥ����ʾ���L�� (0X4C)����ӦAPI��BeginTransLcmd,
        /// ���ֱ�ǩȺ����ʾ���ֻ֧�ֺ��ֱ�ǩ��
        /// </summary>
        /// <returns></returns>
        [DllImport("LanCmdSender.dll")]
        public static extern int BeginTransLcmd(); //���ֱ�ǩȺ����ʾ����

        /// <summary>
        /// Ⱥ����ʾ���L�� (0X4C)����ӦAPI��AddTransLcmd��
        /// ���ֱ�ǩȺ����ʾ���ֻ֧�ֺ��ֱ�ǩ��
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
        /// Ⱥ����ʾ���L�� (0X4C)����ӦAPI��EndTransLcmd��
        /// ���ֱ�ǩȺ����ʾ���ֻ֧�ֺ��ֱ�ǩ��
        /// </summary>
        /// <returns></returns>
        [DllImport("LanCmdSender.dll")]
        public static extern int EndTransLcmd();

        [DllImport("LanCmdSender.dll")]
        public static extern int BeginTrans5Bcmd(); //[ ����Ⱥ��

        [DllImport("LanCmdSender.dll")]
        public static extern int AddTrans5Bcmd(string lpszCargo);

        [DllImport("LanCmdSender.dll")]
        public static extern int EndTrans5Bcmd();

        [DllImport("LanCmdSender.dll")]
        public static extern int BeginTrans5Dcmd(); //] ����Ⱥ��

        [DllImport("LanCmdSender.dll")]
        public static extern int AddTrans5Dcmd(string lpszCargo, int iLine, int bCmdScroll);

        [DllImport("LanCmdSender.dll")]
        public static extern int EndTrans5Dcmd();

        /// <summary>
        /// �ı���ʾ��ʽ���E�� (0X45)����ӦAPI��TransEcmd��
        /// �ı���ʾ��ʽ����ʾ��ʽ�����������ף���ֻ֧�ֺ��ֱ�ǩ��
        /// </summary>
        /// <param name="lpszCargo"></param>
        /// <param name="iLine"></param>
        /// <param name="bShowMode"></param>
        /// <returns></returns>
        [DllImport("LanCmdSender.dll")]
        public static extern int TransEcmd(string lpszCargo, int iLine, int bShowMode);

        /// <summary>
        /// ����ʾ��ָ�������F�� (0X46)����ӦAPI��TransFcmd��
        /// ����ʾ��ָ�������ֻ֧�ֺ��ֱ�ǩ��
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
        /// �����޸����P������ӦAPI��TransZcmd���޸ĵ��ӱ�ǩ�����ţ����������ֺͺ��ֱ�ǩ��
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
            int iCol3, string lpszLine3, int iCol4, string lpszLine4, char chLight); //�����ַ���ǩ������ʾָ��
        /// <summary>
        /// ���������´����Z������ӦAPI��TransZcmd
        /// </summary>
        /// <returns></returns>
        [DllImport("LanCmdSender.dll")]
        public static extern int TransZcmds();

        [DllImport("LanCmdSender.dll")]
        public static extern int Transucmd(string lpszCargo);

        [DllImport("LanCmdSender.dll")]
        public static extern int TransCcmd(string lpszCargo, int bLightOn);

        /// <summary>
        /// ������ʾָ�������V�� (0X56)����ӦAPI��TransVcmd��
        /// ������ʾָ�����ı���Ϣ��ֻ֧�ֺ��ֱ�ǩ��
        /// </summary>
        /// <param name="lpszCargo"></param>
        /// <param name="uLine"></param>
        /// <param name="bScrool"></param>
        /// <returns></returns>
        [DllImport("LanCmdSender.dll")]
        public static extern int TransVcmd(string lpszCargo, int uLine, int bScrool);

        /// <summary>
        /// ������ǩ��������W�� (0X57)����ӦAPI��TransWcmd��
        /// ���ر�ǩ����ƣ�ֻ֧�ֺ��ֱ�ǩ��
        /// </summary>
        /// <param name="lpszCargo"></param>
        /// <param name="bLightOn"></param>
        /// <returns></returns>
        [DllImport("LanCmdSender.dll")]
        public static extern int TransWcmd(string lpszCargo, int bLightOn);

        #endregion
    */

    /// <summary>
    /// ͨ�������´����T��(0X51), ��ӦAPI��TransTcmd��
    /// �´����ݵ����ӱ�ǩ��ֻ֧�����ֱ�ǩ��
    /// </summary>
    /// <param name="lpszCargo">��ʾ��ǩ���</param>
    /// <param name="lpData"></param>
    /// <param name="chLight">��ʾָʾ�Ƶ���ʾ��ȡֵ���£�J(4AH) - ��ʾ�����; K(4BH) - ��ʾ������; L(4CH) - ��ʾ�̵���; G(47H) - ��ʾָʾ����</param>
    /// <param name="chLightCmd">ָʾ�ƿ��Ʋ���,ȡֵ0/1,��ʾ��/��,Ϊ0ʱ����chLight����</param>
    /// <param name="chBeep">���������ز���,ȡֵ0/1,���ߡ�0��/��1��,��ʾ����/����</param>
    /// <returns></returns>
    [DllImport("LanCmdSender.dll")]
    //public static extern int TransTcmd(string lpszCargo, string lpData, char chLight, char chLightCmd, char chBeep);

    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool TransTcmd([In] [MarshalAs(UnmanagedType.LPStr)] string lpszCargo, [In] [MarshalAs(UnmanagedType.LPStr)] string lpData, byte chLight, byte chLightCmd, byte chBeep);
    //ͨ�������´����T��
    /// <summary>
    /// Ⱥ�������´����A�� ,��ӦAPI��BeginTransTcmds���´����ݵ�������ӱ�ǩ��ֻ֧�����ֱ�ǩ��
    /// </summary>
    /// <returns></returns>
    [DllImport("LanCmdSender.dll")]
    public static extern int BeginTransTcmds(); //����Ⱥ��ָ��

    /// <summary>
    /// Ⱥ�������´����A�� ,��ӦAPI��AddTransTcmd���´����ݵ�������ӱ�ǩ��ֻ֧�����ֱ�ǩ��
    /// </summary>
    /// <param name="lpszCargo"></param>
    /// <param name="lpData"></param>
    /// <param name="chLight"></param>
    /// <param name="chBeep"></param>
    /// <returns></returns>
    [DllImport("LanCmdSender.dll")]
    public static extern int AddTransTcmd(string lpszCargo, string lpData, char chLight, char chBeep);

    /// <summary>
    /// Ⱥ�������´����A�� ,��ӦAPI��EndTransTcmds���´����ݵ�������ӱ�ǩ��ֻ֧�����ֱ�ǩ��
    /// </summary>
    /// <returns></returns>
    [DllImport("LanCmdSender.dll")]
    public static extern int EndTransTcmds();
    /// <summary>
    /// �����������������K�� (0X4B)����ӦAPI��TransKcmd��
    /// ���Ƶ��ӱ�ǩ������������֧�ֺ��ֱ�ǩ�����ֱ�ǩ��
    /// </summary>
    /// <param name="lpszCargo"></param>
    /// <returns></returns>
    [DllImport("LanCmdSender.dll")]
    public static extern int TransKcmd(string lpszCargo); //�����������K��

    /// <summary>
    /// �رտ�������Դָ�U������ӦAPI��TransUcmd������ͣ���ر�ʹ��
    /// </summary>
    /// <returns></returns>
    [DllImport("LanCmdSender.dll")]
    public static extern int TransUcmd(); //shutdown power

    /// <summary>
    /// ��ʾ���л��������&�� (0X26)����ӦAPI��TransIDcmd��
    /// ���ӱ�ǩ��ʾ���Ի����ţ�֧�ֺ��ֱ�ǩ�����ֱ�ǩ��
    /// </summary>
    /// <returns></returns>
    [DllImport("LanCmdSender.dll")]
    public static extern int TransIDcmd(); //show id

    /// <summary>
    /// �����޸����P��, ���ݻ����޸�, ��ӦAPI��TransPcmd
    /// </summary>
    /// <param name="lpszCargo"></param>
    /// <param name="lpszCargoNew"></param>
    /// <returns></returns>
    [DllImport("LanCmdSender.dll")]
    public static extern int TransPcmd(string lpszCargo, string lpszCargoNew); //change label ID

    /// <summary>
    /// �����޸����P��, ����COM �ںͱ�ǩID �޸Ļ���, ��ӦAPI��TransPcmd2
    /// </summary>
    /// <param name="uLblID"></param>
    /// <param name="uPort"></param>
    /// <param name="lpszCargoNew"></param>
    /// <returns></returns>
    [DllImport("LanCmdSender.dll")]
    public static extern int TransPcmd2(int uPort, int uLblID, string lpszCargoNew);

    /// <summary>
    /// �����޸����P��, �޸������ǩID, ��ӦAPI��TransPcmd3
    /// </summary>
    /// <param name="uPort"></param>
    /// <param name="uLblID"></param>
    /// <param name="uLblNewID"></param>
    /// <returns></returns>
    [DllImport("LanCmdSender.dll")]
    public static extern int TransPcmd3(int uPort, int uLblID, int uLblNewID);

    /// <summary>
    /// ��ǩ��ѯ���Q�� (0X51)���������ӱ�ǩ״̬, ��ӦAPI��TransQcmd�������������ֱ�ǩ��
    /// </summary>
    /// <param name="lpszCargo"></param>
    /// <returns></returns>
    [DllImport("LanCmdSender.dll")]
    public static extern int TransQcmd(string lpszCargo); //ͨ��״̬��ѯ����"Q" (0X51), �������ӱ�ǩ״̬��ֻ֧�����ֱ�ǩ��

    /// <summary>
    /// ��ǩ�������b�� ����ӦAPI��Transbcmd��
    /// </summary>
    /// <param name="lpszCargo"></param>
    /// <param name="lpszConfig"></param>
    /// <returns></returns>
    [DllImport("LanCmdSender.dll")]
    public static extern int Transbcmd(string lpszCargo, string lpszConfig); //config label

    /// <summary>
    /// ��������(0X0C)����ӦAPI��Trans0Ccmd
    /// </summary>
    /// <param name="lpszCargo"></param>
    /// <returns></returns>
    [DllImport("LanCmdSender.dll")]
    //public static extern int Trans0Ccmd(string lpszCargo);

    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool Trans0Ccmd([In, MarshalAs(UnmanagedType.LPStr)] string lpszCargo);
    /// <summary>
    /// ������ʶ�������I��������ӦAPI��Trans49cmd
    /// </summary>
    /// <param name="lpszCargo"></param>
    /// <returns></returns>
    [DllImport("LanCmdSender.dll")]
    public static extern int Trans49cmd(string lpszCargo); //|

    [DllImport("LanCmdSender.dll")]
    public static extern int TransAddCmd(int uPort, int uID, string lpszCargo); //����ɾ����ǩָ��

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
    /// ��������ͻ��˷�������ʱ���ͻ����յ����������͹�������Ϣ
    /// </summary>
    public const int DATA_RECV = 0x0400 + 19;
    /// <summary>
    /// �ͻ������ӵ��������󣬿�������ͻ��˷��͵���Ϣ
    /// </summary>
    public const int PC_CONN = 0x0400 + 20;
}
